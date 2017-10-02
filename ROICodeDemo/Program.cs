using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TwinFinder;

namespace ROICodeDemo
{
    class Program
    {
        protected static string originalString = string.Empty;
        protected static string finalString = string.Empty;

        static void Main(string[] args)
        {
            if(args != null && args.Count() > 0)
            {
                originalString = args[0];
                Test();
            }
            else
            {
                originalString = "Test this string one time, and one time more. EIGHt it out.";
                Test();
            }
        }

        public static void Test(string testString = null)
        {
            //reference: homophone.com
            //zero, xero
            //one, won
            //two, to, too
            //three
            //fore, for, four
            //five           
            //six, sics
            //seven
            //eight, ait, ate
            //nine

            string targetString = string.Empty;
            string finalTargetString = string.Empty;

            if (string.IsNullOrEmpty(originalString) && testString != null)
            {
                targetString = testString;
            }
            else if (string.IsNullOrEmpty(originalString) && testString == null)
            {
                return;
            }
            else
            {
                targetString = originalString;
            }

            string initialPart = string.Empty;       

            //nine
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex10 = new Regex(@"^(.*)(eight|ate|aiht)(.*)");
            Match match10 = regex10.Match(targetString);
            if(!match10.Success)
            {
                finalTargetString = targetString;
            }
            while (match10.Success)
            {
                finalTargetString = string.Concat(match10.Groups[3], finalTargetString);

                finalTargetString = string.Concat("NINE", finalTargetString);

                initialPart = match10.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match10 = regex10.Match(initialPart);
                if (!match10.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //eight
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex9 = new Regex(@"^(.*)(eight|ate|aiht)(.*)");
            Match match9 = regex9.Match(targetString);
            if (!match9.Success)
            {
                finalTargetString = targetString;
            }
            while (match9.Success)
            {
                finalTargetString = string.Concat(match9.Groups[3], finalTargetString);

                finalTargetString = string.Concat("nine", finalTargetString);

                initialPart = match9.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match9 = regex9.Match(initialPart);
                if (!match9.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //seven
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex8 = new Regex(@"^(.*)(seven)(.*)");
            Match match8 = regex8.Match(targetString);
            if (!match8.Success)
            {
                finalTargetString = targetString;
            }
            while (match8.Success)
            {
                finalTargetString = string.Concat(match8.Groups[3], finalTargetString);

                finalTargetString = string.Concat("eight", finalTargetString);

                initialPart = match8.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match8 = regex8.Match(initialPart);
                if (!match8.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //six
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex7 = new Regex(@"^(.*)(six|sics)(.*)");
            Match match7 = regex7.Match(targetString);
            if (!match7.Success)
            {
                finalTargetString = targetString;
            }
            while (match7.Success)
            {
                finalTargetString = string.Concat(match7.Groups[3], finalTargetString);

                finalTargetString = string.Concat("seven", finalTargetString);

                initialPart = match7.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match7 = regex7.Match(initialPart);
                if (!match7.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //five
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex6 = new Regex(@"^(.*)(five)(.*)");
            Match match6 = regex6.Match(targetString);
            if (!match6.Success)
            {
                finalTargetString = targetString;
            }
            while (match6.Success)
            {
                finalTargetString = string.Concat(match6.Groups[3], finalTargetString);

                finalTargetString = string.Concat("six", finalTargetString);

                initialPart = match6.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match6 = regex6.Match(initialPart);
                if (!match6.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //four
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex5 = new Regex(@"^(.*)(four|for|fore)(.*)");
            Match match5 = regex5.Match(targetString);
            if (!match5.Success)
            {
                finalTargetString = targetString;
            }
            while (match5.Success)
            {
                finalTargetString = string.Concat(match5.Groups[3], finalTargetString);

                finalTargetString = string.Concat("five", finalTargetString);

                initialPart = match5.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match5 = regex5.Match(initialPart);
                if (!match5.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //three
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex4 = new Regex(@"^(.*)(three)(.*)");
            Match match4 = regex4.Match(targetString);
            if (!match4.Success)
            {
                finalTargetString = targetString;
            }
            while (match4.Success)
            {
                finalTargetString = string.Concat(match4.Groups[3], finalTargetString);

                finalTargetString = string.Concat("four", finalTargetString);

                initialPart = match4.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match4 = regex4.Match(initialPart);
                if (!match4.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //two
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex3 = new Regex(@"^(.*)(two|to|too)(.*)");
            Match match3 = regex3.Match(targetString);
            if (!match3.Success)
            {
                finalTargetString = targetString;
            }
            while (match3.Success)
            {
                finalTargetString = string.Concat(match3.Groups[3], finalTargetString);

                finalTargetString = string.Concat("three", finalTargetString);

                initialPart = match3.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match3 = regex3.Match(initialPart);
                if (!match3.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //ONE
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex = new Regex(@"^(.*)(one|won)(.*)");
            Match match = regex.Match(targetString);
            if (!match.Success)
            {
                finalTargetString = targetString;
            }
            while (match.Success)
            {
                finalTargetString = string.Concat(match.Groups[3], finalTargetString);

                finalTargetString = string.Concat("two", finalTargetString);

                initialPart = match.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match = regex.Match(initialPart);
                if (!match.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            //zero
            targetString = finalTargetString;
            finalTargetString = string.Empty;
            initialPart = string.Empty;
            Regex regex2 = new Regex(@"^(.*)(zero|xero)(.*)");
            Match match2 = regex2.Match(targetString);
            if (!match2.Success)
            {
                finalTargetString = targetString;
            }
            while (match2.Success)
            {
                finalTargetString = string.Concat(match2.Groups[3], finalTargetString);

                finalTargetString = string.Concat("one", finalTargetString);

                initialPart = match2.Groups[1].Value;

                Console.WriteLine(finalTargetString);
                match2 = regex2.Match(initialPart);
                if (!match2.Success)
                {
                    finalTargetString = string.Concat(initialPart, finalTargetString);
                }
            }

            finalString = finalTargetString;
        }
    }
}

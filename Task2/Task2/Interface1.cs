using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal static class ExtensionsClass
    {

        public static bool IsOdd(this int num)
        {

            if (num % 2 != 0)
            {


                return true;
            }
            else return false;


        }

        public static bool IsEven(this int num)
        {

            if (num % 2 == 0)
            {


                return true;
            }
            else return false;


        }

        public static bool IsContainsDigit(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    return true;


                }


            }
            return false;
        }

        public static string ToCapitalize(this string text)
        {

            text[0].ToString().ToUpper();

            return text;

        }

        public static int[] GetValueIndexes(this string text, char c)
        {
            int[] IndexArray = new int[0];
            for (int i = 0; i < text.Length; i++)
            {

                if (c == text[i])
                {
                    Array.Resize(ref IndexArray, IndexArray.Length + 1);

                    IndexArray[IndexArray.Length - 1] = text[i];
                }



            }

            return IndexArray;


        }

        public static string GetFirstSentence(this string text)
        {
            int num = text.IndexOf('.');

            string text1 = text.Substring(0, num);


            return text1;
        }

        public static string GetSecondWord(this string text)
        {

            int index = text.IndexOf(' ');

            string tex1 = text.Substring(index, ' ');

            return tex1;

        }

    }
}

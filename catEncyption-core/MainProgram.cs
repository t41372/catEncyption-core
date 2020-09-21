using System;
using System.Text;

namespace catEncyption_core
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            

            string sourceText = Console.ReadLine();

            string encodeText = encrypt(sourceText);

            Console.WriteLine("sourceText == " + sourceText);

            Console.WriteLine("encode == " + encodeText);

            //Console.WriteLine("decode == " + decode(encodeText));


            Console.WriteLine("---end---");
        }

        public static string encrypt(string sourceText)
        {
            //to base64
            byte[] cacheFromSourceText = System.Text.Encoding.GetEncoding("unicode").GetBytes(sourceText);
            char[] textInBase64 = Convert.ToBase64String(cacheFromSourceText).ToCharArray();

            printer("Base64", textInBase64, false);//DEBUG

            //to ascii
            int[] textInAscii = new int[textInBase64.Length];

            for(int index = 0; index < textInAscii.Length; index ++)
            {
                textInAscii[index] = Convert.ToInt32(textInBase64[index]);
            }

            printer("Ascii", textInAscii, true); //DEBUG


            //to binary
            




            return sourceText;
        }

        public static string decode(string sourceText)
        {



            //decode base64 and return

            return Encoding.Unicode.GetString(Convert.FromBase64String(sourceText));
        }




        //! DEBUG-==============
        private static void printer(string whoAmI, Array source, bool space)
        {
            Console.Write("\n" + whoAmI + ": ");
            foreach (object a in source)
            {
                Console.Write(a);
                if (space) Console.Write(" ");
            }
            Console.WriteLine();
        }

        


        //! DEBUG-==============


    }
}

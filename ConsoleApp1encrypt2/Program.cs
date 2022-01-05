// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
MyNamespace.Program.CaesarCypherEncryptor("xyz", 2);
MyNamespace.Program.extra();
MyNamespace.Program.dubleextra('a');


namespace MyNamespace
{
    public  class Program
    {
        // O(n) time | O(n) space
        public static string CaesarCypherEncryptor(string str, int key)
        {
            Console.WriteLine("Encrypt");
            char[] newLetters = new char[str.Length];
            int newKey = key % 26;
            for (int i = 0; i < str.Length; i++)
            {
                newLetters[i] = getNewLetter(str[i], newKey);
            }
            foreach(char c in newLetters)
            {
                Console.Write(c + "");
            }
            Console.WriteLine();
            string s = new string(newLetters);
            Console.WriteLine(s);
            Console.WriteLine(  );

            return new string(newLetters);
        }
        public static char getNewLetter(char letter, int key)
        {
            int newLetterCode = letter + key;
            return newLetterCode <=
            122 ? (char)newLetterCode : (char)(96 + newLetterCode % 122);
        }

        public static void extra()
        {
            Console.WriteLine(" Inside Extra");
            string ss = CaesarCypherEncryptor("abc", 2);
        }

        public static void dubleextra(char a)
        {
            Console.WriteLine(" Inside !! ");
           
            int res = a + 2;
            Console.WriteLine(res + " ## ");
            Console.WriteLine();
            
        }
    }

}
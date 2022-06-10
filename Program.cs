//Michel Jurado 

using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            bool y = true;
            do {
                Console.WriteLine("Please input your secret message");

                string secretMessage = Console.ReadLine();

                //converting string into an array of char with ToCharArray()
                char[] secretMessageArray = secretMessage.ToCharArray();

                char[] encryptedMessage = new char[secretMessageArray.Length];

                for (int i = 0; i < secretMessage.Length; i++)
                {
                    char x = secretMessageArray[i];

                    //searching for position of char in alphabet array
                    int index = Array.IndexOf(alphabet, x);
                    int newIndex = (index + 3) % alphabet.Length; //now the letter position will never go past 26;
                    char newChar = alphabet[newIndex];

                    //pushing new letter into encrypted message array
                    encryptedMessage[i] = newChar;


                }



                string encryptedMessageString = String.Join("", encryptedMessage);
                Console.WriteLine(encryptedMessageString);

                Console.WriteLine("Do you want to continue (y/n)?");
                string cont = Console.ReadLine();

                if (cont == "n")
                {
                    y = false;
                }
            }
            while (y);
            
        }
    }
}


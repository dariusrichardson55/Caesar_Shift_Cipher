using System;
using System.IO;
using System.Linq;

class Caesar_Shift_Cipher
{


    // Encode Text: 
    public static char cipher(char character, int shift)
    {
        if (!char.IsLetter(character))
        {

            return character;
        }

        // Detects the character and moves it up depending on what number the user enters 
        char a = char.IsUpper(character) ? 'A' : 'a';
        return (char)((((character + shift) - a) % 26) + a);


    }

    // Decode text: Detects the character and moves it down depending on what number the user enters 
    public static char decipher(char character, int shift)
    {
        if (!char.IsLetter(character))
        {

            return character;
        }


        // Detects if Capital letters has been entered

        char a = char.IsUpper(character) ? 'A' : 'a';
        return (char)((((character - shift) + a) % 26) + a);

        // Encode Text: 
    }

    public static string Encipher(string input, int shift)
    {
        string result = string.Empty;


        // result the encoded text
        foreach (char character in input)
            result += cipher(character, shift);

        return result;
    }

    // Moves the shift down

    public static string Decipher(string input, int shift)
    {
        return Encipher(input, 26 + shift);
    }

    // Decode Text

    public static string cipher(string input, int shift)
    {
        string result = string.Empty;

        // Decipher: Writen code into normal langauge
        foreach (char character in input)
            result += decipher(character, shift);

        return result;
    }

    // Moves the shift down

    public static string decipher(string input, int shift)
    {
        return Encipher(input, 26 - shift);
    }

    static char Encode(char character, int shift)
    {
        if (!char.IsLetter(character)) return character;

        char offset = char.IsUpper(character) ? 'A' : 'a';
        return (char)((character + shift - offset) % 26 + offset);
    }

    static string Encode(string input, int shift)
    {
        return new string(input.Select(character => Encode(character, shift)).ToArray());
    }

    static string Decode(string input, int shift)
    {
        return Encode(input, 26 - shift);
    }

    const string EncodedText = "EncodedText.txt";




    // Displays the Plain text, Encoded Text, Shift number. Messages for the user.



    public static void Main(string[] args)
    {

        Console.Write("Enter plain text:");
        string UserString = Console.ReadLine();



        Console.Write("Enter shift:");
        int shift = Convert.ToInt32(Console.ReadLine());





        Console.Write("\nEnter Encoded text:");
        string UserString2 = Console.ReadLine();



        Console.Write("Enter shift:");
        int shift2 = Convert.ToInt32(Console.ReadLine());








        {
            // Displays the Plain text, Encoded Text, Shift number. Messages for the user.


            Console.Write("\nx = {0}", shift);
            Console.Write("\nPlain text:");


            string encodedtext = Encipher(UserString, shift);
            Console.Write(UserString);

            Console.Write("\nEncoded text:");

            string decodedtext = Decipher(UserString, shift);
            Console.Write(decodedtext);

            Console.Write("\n\nx = {0}", shift2);


            Console.Write("\nEncoded text:");

            string decodedtext2 = cipher(UserString2, shift2);
            Console.Write(UserString2);


            string encodedtext2 = decipher(UserString2, shift2);

            Console.Write("\nPlain text:");
            Console.Write(encodedtext2);

            Console.WriteLine("\n\nPress enter for the shift value and to Reveal the Plain text for the Encoded text.txt:\n");
            Console.ReadLine();

        }

        {
            string text = File.ReadAllText(EncodedText);
            Console.WriteLine("\n The Shift for the Encoded text is 10:\n ");
            text = Encode(text, 10);
            Console.WriteLine("\nDecoded:\n " + text);
            text = Decode(text, 10);
            Console.WriteLine("\nEncoded:\n " + text);
            Console.WriteLine("\n\nPress any key to exit program\n");
            Console.ReadKey();
        }


        {

            // Encoded text from EncodedText.txt broken down into some numbers
            /*
            a = 5
            b = 24
            c = 12 
            d= 52
            e = 34
            f =13
            h = 31
            i = 32
            j = 76
            K = 13
            l = 9
            m = 13
            n = 2
            o = 7
            q = 71
            r = 6
            s = 20
            t = 25
            u = 80
            v = 13
            w = 7
            x = 38
            y = 48


            u = e

            shift = 10
            */


        }
    }


}












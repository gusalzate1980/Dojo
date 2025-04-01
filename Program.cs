/*
 * A phrase is considered a palindrome if, after converting all characters into lowercase and removing all non-alphanumeric characters, 
 * it reads the same forward and backward. Alphanumeric characters include letters and numbers.
 * Write a function isPalindrome that takes a string s as input and returns true if it is a palindrome, or false otherwise.. 
 */

using System.Security.Cryptography.X509Certificates;
using System.Text.Json;


string texto1 = "Anita Lava La Tina";
Console.WriteLine(texto1+" "+(texto1.IsPalindrome() ? " Is Palindrome":"Is Not Palindrome"));

string texto2 = "Anita$Lava#La=Tina";
Console.WriteLine(texto2 + " " + (texto2.IsPalindrome() ? " Is Palindrome" : "Is Not Palindrome"));

string texto3 = "Pepito no LAva la TiNa";
Console.WriteLine(texto3 + " " + (texto3.IsPalindrome() ? " Is Palindrome" : "Is Not Palindrome"));

string texto4 = "   abC * 123 -- 321cBA  ";
Console.WriteLine(texto4 + " " + (texto4.IsPalindrome() ? " Is Palindrome" : "Is Not Palindrome"));


public static class Palindrome
{
    
    public static bool IsPalindrome(this string text)
    { 
        Queue<char> startToEnd = new Queue<char>();
        Stack<char> endToStart = new Stack<char>();

        foreach (char c in text)
        {
            if (Char.IsLetter(c) || Char.IsDigit(c))
            {
                startToEnd.Enqueue(c);
                endToStart.Push(c);
            }    
        }

        while (startToEnd.Count > 0)
        {
            if(startToEnd.Dequeue() != endToStart.Pop())
            {
                return false;
            }
        }

        return true;
    }
}
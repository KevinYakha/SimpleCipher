using System;
using System.Linq;
using System.Security.Cryptography;

public class SimpleCipher
{
    public SimpleCipher()
    {
        Random rng = new Random();
        char[] temp = new char[100];
        for (var i = 0; i < 100; i++)
        {
            temp[i] = _chars[rng.Next(_chars.Length)];
        }
        _key = new string(temp);
    }

    public SimpleCipher(string key)
    {
        _key = key;
    }
    
    public string Key 
    {
        get
        {
            return _key;       
        }
    }

    public string Encode(string plaintext)
    {
        char[] cipher = plaintext.ToCharArray();
        for (int i = 0; i < plaintext.Length; i++)
        {
            int charIndex = 0; // index of original char
            while (plaintext[i] != _chars[charIndex])
            {
                charIndex++;
            }

            int shiftAmount = 0;
            while (_key[i % _key.Length] != _chars[shiftAmount])
            {
                shiftAmount++;
            }
            charIndex = (charIndex + shiftAmount) % _chars.Length;
                cipher[i] = _chars[charIndex];
        }
        return new string(cipher);
    }

    public string Decode(string ciphertext)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    private string _key;
    private char[] _chars = { 'a', 'b', 'c', 'd', 'e',
        'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
        'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
}
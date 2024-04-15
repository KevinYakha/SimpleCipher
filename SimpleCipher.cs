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
        throw new NotImplementedException("You need to implement this function.");
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
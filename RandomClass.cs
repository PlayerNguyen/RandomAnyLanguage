using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Random By Player Nguyen. Info https://github.com/PlayerNguyen/RandomAnyLanguage
/// </summary>
public class RandomClass
{

    /// <summary>
    /// Random Integer Random C#
    /// </summary>
    /// <param name="min">Max value of random</param>
    /// <param name="max">Min value of random</param>
    /// <returns></returns>
    public static int RandomInt(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min, max);
    }


    /// <summary>
    /// Random String Random C#
    /// </summary>
    /// <param name="chars">Aphabet Char. Use any type</param>
    /// <param name="length">Length of this String</param>
    /// <returns></returns>
    public static string RandomString(String chars, int length)
    {  
        var random = new Random();
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    /// <summary>
    /// Random Double Random C#
    /// 
    /// </summary>
    /// <param name="min">double</param>
    /// <param name="max">double</param>
    /// <returns>double</returns>
    public static double RandomDouble(double min, double max)
    {
        return new Random().NextDouble() * (max - min) + min; 
    }

    /// <summary>
    /// Random Char Random C#
    /// </summary>
    /// <returns></returns>
    public static char RandomChar()
    {
        String chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
        Random rand = new Random();
        int num = rand.Next(0, chars.Length - 1);
        return chars[num];
    }

    /// <summary>
    /// Random With Custom Char
    /// </summary>
    /// <param name="chars">Char</param>
    /// <returns></returns>
    public static char RandomChar(String chars)
    {
        Random rand = new Random();
        int num = rand.Next(0, chars.Length - 1);
        return chars[num];
    }

    /// <summary>
    /// Random Boolean Random C#
    /// </summary>
    /// <returns></returns>
    public static bool RandomBoolean()
    {
        Random rand = new Random();
        int valueBool = rand.Next(0, 2);

        if (valueBool == 0)
        {
            return false;
        }
        else if (valueBool == 1)
        {
            return true;
        }

        return false;

    }

}

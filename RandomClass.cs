using System;
using System.Linq;

/// <summary>
/// RandomAnyLanguage
/// RandomAnyLanguage By Player Nguyen. Info https://github.com/PlayerNguyen/RandomAnyLanguage
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
        string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
        Random rand = new Random();
        int num = rand.Next(0, chars.Length - 1);
        return chars[num];
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

public static class WheelOfFortune
{
    public static void Main()
    {
        List<Phrase> phrases = new List<Phrase>();
        Phrase p1 = new Phrase("THIS IS A TEST", Category.WhatAreYouDoing);
        phrases.Add(p1);

        Random random = new Random();
        Phrase currentPhrase = phrases[random.Next(phrases.Count)];

        string guess = "";
        for (int i = 0; i < currentPhrase.spelling.Length; i++)
        {
            if (currentPhrase.spelling[i] == ' ')
            {
                guess += "  ";
            }
            else
            {
                guess += "_ ";
            }
        }

        Console.WriteLine(guess);
        Console.WriteLine(currentPhrase.category.GetDescription());
    }

    public static string GetDescription<T>(this T enumerationValue)
    where T : struct
    {
        Type type = enumerationValue.GetType();
        if (!type.IsEnum)
        {
            throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
        }

        MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
        if (memberInfo != null && memberInfo.Length > 0)
        {
            object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attrs != null && attrs.Length > 0)
            {
                return ((DescriptionAttribute)attrs[0]).Description;
            }
        }

        return enumerationValue.ToString();
    }
}
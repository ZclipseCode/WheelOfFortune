using System;
using System.Collections.Generic;

public static class WheelOfFortune
{
    public static void Main()
    {
        List<Phrase> phrases = new List<Phrase>();
        Phrase p1 = new Phrase("THIS IS A TEST", Category.WhatAreYouDoing, "WHAT ARE YOU DOING?");
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
    }
}
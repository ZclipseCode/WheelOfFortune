using System;

public class Phrase
{
    public string spelling;
    public Category category;
    public string visibleCategory;

    public Phrase(string spelling, Category category, string visibleCategory)
    {
        this.spelling = spelling;
        this.category = category;
        this.visibleCategory = visibleCategory;
    }
}
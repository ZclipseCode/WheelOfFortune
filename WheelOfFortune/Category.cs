using System;
using System.ComponentModel;

public enum Category
{
    [Description("AROUND THE HOUSE")]
    AroundTheHouse,
    [Description("BEFORE & AFTER")]
    BeforeAndAfter,
    [Description("BEST SELLER(S)")]
    BestSellers,
    [Description("CHARACTER(S)")]
    Characters,
    [Description("CLASSIC TV")]
    ClassicTV,
    [Description("COLLEGE LIFE")]
    CollegeLife,
    [Description("EVENT(S)")]
    Events,
    [Description("FAMILY")]
    Family,
    [Description("FUN & GAMES")]
    FunAndGames,
    [Description("FOOD & DRINK")]
    FoodAndDrink,
    [Description("HEADLINE")]
    Headline,
    [Description("HUSBAND & WIFE")]
    HusbandAndWife,
    [Description("IN THE KITCHEN")]
    InTheKitchen,
    [Description("LANDMARK(S)")]
    Landmarks,
    [Description("LIVING THING(S)")]
    LivingThings,
    [Description("MOVIE QUOTE")]
    MovieQuote,
    [Description("TV QUOTE")]
    TVQuote,
    [Description("OCCUPATIONS")]
    Occupations,
    [Description("ON THE MAP")]
    OnTheMap,
    [Description("PERSON / PEOPLE")]
    PersonPeople,
    [Description("PHRASE(S)")]
    Phrases,
    [Description("PLACE(s)")]
    Places,
    [Description("PROPER NAME(S)")]
    ProperNames,
    [Description("QUOTATION")]
    Quotation,
    [Description("RYHME TIME")]
    RhymeTime,
    [Description("SAME LETTER")]
    SameLetter,
    [Description("SAME NAME")]
    SameName,
    [Description("SHOW BIZ")]
    ShowBiz,
    [Description("SONG / ARTIST")]
    SongArtist,
    [Description("SONG LYRICS")]
    SongLyrics,
    [Description("STAR & ROLE")]
    StarAndRole,
    [Description("THING(S)")]
    Things,
    [Description("TITLE(S)")]
    Titles,
    [Description("TITLE / AUTHOR")]
    TitleAuthor,
    [Description("WHAT ARE YOU DOING?")]
    WhatAreYouDoing,
    [Description("WHAT ARE YOU WEARING?")]
    WhatAreYouWearing
}
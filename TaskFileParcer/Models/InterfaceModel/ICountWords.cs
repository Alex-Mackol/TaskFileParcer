using System;

namespace TaskFileParcer.Models.InterfaceModel
{
    public interface ICountWords
    {
        string Link { get; set; }
        string WordToCount { get; set; }
        int FindAmountOfWord();
    }
}

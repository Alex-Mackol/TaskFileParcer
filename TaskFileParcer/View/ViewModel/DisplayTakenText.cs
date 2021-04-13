using System;

namespace TaskFileParcer.View.ViewModel
{
    class DisplayTakenText
    {
        public void DisplayAmountOfWords(int amountOfWords, string stringToCount)
        {
            Console.WriteLine($"This faile contains : {amountOfWords} enterences of string \"{stringToCount}\"");
        }
    }
}

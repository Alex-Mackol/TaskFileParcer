using System;

using TaskFileParcer.View.InterfaceView;

namespace TaskFileParcer.View.ViewModel
{
    class DisplayTakenText: IDisplay
    {
        public void DisplayAmountOfWords(int amountOfWords, string stringToCount)
        {
            if (amountOfWords != 0)
            {
                Console.WriteLine($"This faile contains : {amountOfWords} enterences of string \"{stringToCount}\"");
            }
            else
            {
                Console.WriteLine($"This faile doesn`t contain string \"{stringToCount}\"");
            }
        }

        public void WriteText(string message)
        {
            Console.WriteLine(message);
        }
    }
}

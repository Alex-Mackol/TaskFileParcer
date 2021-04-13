using System;

using TaskFileParcer.View.ViewModel;
using TaskFileParcer.Models.ClassModel;
using TaskFileParcer.Models.InterfaceModel;

namespace TaskFileParcer.Controllers.ControllerModel
{
    class ParcerController
    {
        public ParcerController()
        {

        }

        public void InputText(string[] args)
        {
            Validator validator = new Validator();
            DisplayTakenText text = new DisplayTakenText();

            if (args.Length > 0 && validator.IsExistedDirectory(args[0]))
            {
                if (args.Length == 2)
                {
                    int amountOfWords;
                    ICountWords countWords = new Parcer(args[0], args[1]);
                    amountOfWords = countWords.FindAmountOfWord();
                    text.DisplayAmountOfWords(amountOfWords, args[1]);
                }
                else if (args.Length == 3)
                {
                    IChangeString changeString = new Parcer(args[0], args[1], args[2]);
                    changeString.ChangeStrings();
                    Console.WriteLine("File changed!");
                }
            }
            else
            {
                Console.WriteLine("Please enter the right directory!");
            }
        }
    }
}


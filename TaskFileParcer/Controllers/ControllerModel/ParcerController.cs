using System;

using TaskFileParcer.View.InterfaceView;
using TaskFileParcer.Models.InterfaceModel;
using TaskFileParcer.Controllers.InterfaceController;

namespace TaskFileParcer.Controllers.ControllerModel
{
    class ParcerController
    {
        IValidator validator;
        IDisplay displayMessage;
        IFactory factory;

        public ParcerController(IValidator validator, IDisplay displayMessage,IFactory factory)
        {
            this.validator = validator;
            this.displayMessage = displayMessage;
            this.factory = factory;
        }

        public void InputText(string[] args)
        {
            if (args.Length > 0 && validator.IsExistedDirectory(args[0]))
            {
                if (args.Length == 2)
                {
                    int amountOfWords;
                    ICountWords countWords = factory.CreateObjectForCounting(args[0], args[1]);
                    amountOfWords = countWords.FindAmountOfWord();
                    displayMessage.DisplayAmountOfWords(amountOfWords, args[1]);
                }
                else if (args.Length == 3)
                {
                    IChangeString changeString = factory.CreateObjectForChaging(args[0], args[1], args[2]);
                    changeString.ChangeStrings();
                    displayMessage.WriteText("File changed!");
                }
            }
            else
            {
                displayMessage.WriteText("Please enter the right directory!");
            }
        }
    }
}


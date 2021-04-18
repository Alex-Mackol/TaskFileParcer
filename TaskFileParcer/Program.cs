using System;

using TaskFileParcer.Controllers.ControllerModel;
using TaskFileParcer.View.ViewModel;

namespace TaskFileParcer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initialize Components
            Validator validator = new Validator();
            DisplayTakenText displayText = new DisplayTakenText();
            FactoryForParcer factory = new FactoryForParcer();
            #endregion

            ParcerController parcerController = new ParcerController(validator, displayText, factory);
            parcerController.InputText(args);
            Console.ReadKey();
        }
    }
}

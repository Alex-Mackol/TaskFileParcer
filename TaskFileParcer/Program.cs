using System;

using TaskFileParcer.Controllers.ControllerModel; 

namespace TaskFileParcer
{
    class Program
    {
        static void Main(string[] args)
        {
            ParcerController parcerController = new ParcerController();
            parcerController.InputText(args);
            Console.ReadKey();
        }
    }
}

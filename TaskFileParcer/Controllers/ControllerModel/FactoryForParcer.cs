using System;

using TaskFileParcer.Models.ClassModel;
using TaskFileParcer.Controllers.InterfaceController;
using TaskFileParcer.Models.InterfaceModel;

namespace TaskFileParcer.Controllers.ControllerModel
{
    class FactoryForParcer : IFactory
    {
        public IChangeString CreateObjectForChaging(string link, string stringToFind, string stringToChange)
        {
            return new Parcer(link, stringToFind, stringToChange);
        }

        public ICountWords CreateObjectForCounting(string link, string word)
        {
            return new Parcer(link, word);
        }
    }
}

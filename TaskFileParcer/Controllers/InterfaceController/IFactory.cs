using System;

using TaskFileParcer.Models.InterfaceModel;

namespace TaskFileParcer.Controllers.InterfaceController
{
    interface IFactory
    {
        IChangeString CreateObjectForChaging(string link, string stringToFind, string stringToChange);
        ICountWords CreateObjectForCounting(string link, string word);
    }
}

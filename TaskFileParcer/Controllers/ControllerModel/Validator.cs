using System;
using System.IO;

using TaskFileParcer.Controllers.InterfaceController;

namespace TaskFileParcer.Controllers.ControllerModel
{
    class Validator: IValidator
    {
        public bool IsExistedDirectory(string linqToFile)
        {
            return File.Exists(linqToFile);
        }
    }
}

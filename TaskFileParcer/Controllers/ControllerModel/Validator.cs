using System;
using System.IO;

namespace TaskFileParcer.Controllers.ControllerModel
{
    class Validator
    {
        public bool IsExistedDirectory(string linqToFile)
        {
            return File.Exists(linqToFile);
        }
    }
}

using System;

namespace TaskFileParcer.Models.InterfaceModel
{
   public interface IChangeString
    {
        string StringToFind { get; set; }
        string StringToChange { get; set; }
        void ChangeStrings();
    }
}

using System;

namespace TaskFileParcer.Models.InterfaceModel
{
   public interface IChangeString
    {
        string Link { get; set; }
        string StringToFind { get; set; }
        string StringToChange { get; set; }
        void ChangeStrings();
    }
}

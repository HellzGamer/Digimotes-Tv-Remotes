using System;
using System.Collections.Generic;
using System.Text;

namespace TVRemoteLibrary.Interfaces
{
    public interface IRemoteExtraInterface
    {
        List<string> SourceOptions { get; set; }
        string SourceToggle();
        void Menu();
        int Mute();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using TVRemoteLibrary.Interfaces;

namespace TVRemoteLibrary.Models
{
    public class LGRemote : GenericRemote, IRemoteExtraInterface
    {
        public List<string> SourceOptions { get; set; }
        public string CurrentSource { get; set; }
        private int Source { get; set; }

        public LGRemote(int minChannel, int maxChannel, int minVolume, int maxVolume) : base(minChannel, maxChannel, minVolume, maxVolume)
        {
            SourceOptions = new List<string>() { "TV", "HDMI1", "HDMI2", "VGA" }; ;
        }

        public override void PowerOn()
        {
            Source = 0;
            CurrentSource = SourceOptions[Source];
            base.PowerOn();
        }

        public override void PowerOff()
        {
            CurrentSource = "Off";
            base.PowerOff();
        }

        public string Menu()
        {
            return "LG TV Menu";
        }

        public int Mute()
        {
            Volume = MinVolume;
            return Volume;
        }

        public string SourceToggle()
        {
            if (Source == SourceOptions.Count)
            {
                Source = SourceOptions.Count % Source;
            }
            CurrentSource = SourceOptions[Source]; // Assuming when you first click source it does not change as yet until you click it again (VGA was the example output)
            Source++;
            return CurrentSource;
        }
    }
}

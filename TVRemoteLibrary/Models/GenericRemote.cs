using System;
using System.Collections.Generic;
using System.Text;

namespace TVRemoteLibrary.Models
{
    public class GenericRemote
    {
        public int Volume { get; set; }
        public int Channel { get; set; }
        public int MaxChannel { get; set; }
        public int MinChannel { get; set; }
        public int MaxVolume { get; set; }
        public int MinVolume { get; set; }

        // Just decided that TVs can have different max and min volumes, channels
        public GenericRemote(int minChannel, int maxChannel, int minVolume, int maxVolume)
        {
            MaxChannel = maxChannel;
            MinChannel = minChannel;
            MaxVolume = maxVolume;
            MinVolume = minVolume;
        }

        public GenericRemote()
        {

        }

        public virtual void PowerOn()
        {
            Volume = 0;
            Channel = 1;
        }
        public virtual void PowerOff()
        {
            Console.WriteLine("TV Off");
        }

        public virtual int VolumeUp()
        {
            if (Volume < MaxVolume)
            {
                Volume++;
            }
            return Volume;
        }

        public virtual int VolumeDown()
        {
            if (Volume > MinVolume)
            {
                Volume--;
            }
            return Volume;
        }

        public virtual int NextChannel()
        {
            if (Channel == MaxChannel)
            {
                Channel = MinChannel;
            }
            else
            {
                Channel++;
            }
            return Channel;
        }

        public virtual int PreviousChannel()
        {
            if (Channel == MinChannel)
            {
                Channel = MaxChannel;
            }
            else
            {
                Channel--;
            }
            return Channel;
        }
    }
}

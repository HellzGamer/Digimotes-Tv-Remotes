using System;
using TVRemoteLibrary.Models;

namespace DigimotesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var obj = new LGRemote(1, 5, 0, 20);

                //Power On
                obj.PowerOn();

                //Increase volume 3 times
                for (int i = 0; i < 3; i++)
                {
                    obj.VolumeUp();
                }

                //Increase channel once
                obj.NextChannel();

                //Decrease volume
                obj.VolumeDown();

                //Mute TV
                obj.Mute();

                //Previous channel twice
                for (int i = 0; i < 2; i++)
                {
                    obj.PreviousChannel();
                }

                //Call Source function 4 times
                for (int i = 0; i < 4; i++)
                {
                    obj.SourceToggle();
                }

                Console.WriteLine($"Current volume: {obj.Volume}");
                Console.WriteLine($"Current channel: {obj.Channel}");
                Console.WriteLine($"Current source: {obj.CurrentSource}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}

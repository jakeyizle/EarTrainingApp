using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace EarTrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key");
            Console.ReadKey();
            SoundPlayer player = new SoundPlayer();
            Random rnd = new Random();
            int baseNote = rnd.Next(0, 24);
            int otherNote = rnd.Next(0, 24);
            string baseNoteFile = AppDomain.CurrentDomain.BaseDirectory + "resources\\" + baseNote + ".wav";
            string otherNoteFile = AppDomain.CurrentDomain.BaseDirectory + "resources\\" + otherNote + ".wav";
            player.SoundLocation = baseNoteFile;
            player.Play();            
            System.Threading.Thread.Sleep(2000);
            player.SoundLocation = otherNoteFile;
            player.Play();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(Interval(Math.Abs(baseNote - otherNote)));
            Console.ReadKey();
        }
        static string Interval(int interval)
        {
            switch (interval)
            {
                case 0:
                    return "Unison";                    
                case 1:
                case 13:
                    return "Minor Second";
                case 2:
                case 14:
                    return "Major Second";
                case 3:
                case 15:
                    return "Minor Third";
                case 4:
                case 16:
                    return "Major Third";
                case 5:
                case 17:
                    return "Perfect Fourth";
                case 6:
                case 18:
                    return "Tritone";
                case 7:
                case 19:
                    return "Major Fifth";
                case 8:
                case 20:
                    return "Minor Sixth";
                case 9:
                case 21:
                    return "Major Sixth";
                case 10:
                case 22:
                    return "Minor Seventh";
                case 11:
                case 23:
                    return "Major Seventh";
                case 12:
                case 24:
                    return "Perfect Octave";
                default:
                    throw new Exception("Not a valid interval - " + interval);
            }
        }
    }    
}

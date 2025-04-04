using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Colorful;


namespace poe_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //adding voice
            string filePath = "marendaVoice.WAV";


            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                try
                {
                    player.Load();
                    player.PlaySync();
                    System.Console.WriteLine("Audio playback completed.");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Error: " + ex.Message);
                }
            }

            //adding ASCII art
            Colorful.Console.WriteAscii("Rendz CyberBot!", Color.Yellow);
            System.Console.Write("Please enter your name: ");
            string userName = System.Console.ReadLine();
            user userObj = new user();
            chatbot chatbotObj = new chatbot();
            userInteraction interactionObj = new userInteraction(chatbotObj, userObj);
            interactionObj.Chat();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace poe_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user userObj = new user();
            chatbot chatbotObj = new chatbot();
            userInteraction interactionObj = new userInteraction(chatbotObj, userObj);
            interactionObj.Chat();

        }
    }
}
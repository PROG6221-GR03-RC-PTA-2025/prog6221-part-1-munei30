using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_part1
{
    internal class chatbot
    {
        public Dictionary<string, string> chatbotQA = new Dictionary<string, string> {
            {"what is password safety", "Password safety involves creating strong, unique passwords and using methods like multi-factor authentication to protect your accounts." },
            {"what does password safety do","It secures your accounts by preventing unauthorized access through strong password practices and extra security layers." },
            {"what is phishing","Phishing is a cyberattack where attackers impersonate legitimate organizations to steal personal information, often through fake emails or websites."},
            {"what does phishing do","It tricks individuals into revealing sensitive data like passwords or financial details, leading to identity theft or fraud." },
            {"what is safe browsing","Safe browsing refers to practices that protect your privacy and security while navigating the internet, such as avoiding harmful websites and using secure connections." },
            {"what does safe browsing do","It helps prevent exposure to malware, phishing, and other online threats by promoting secure and cautious web browsing habits." }
        };

        public string getResponse(string input, user user)
        {


            input = input.ToLower();

            if (input.Contains("hello") || input.Contains("hi"))
            {
                return "Hello! " + user.name + " How can i assist you today?";
            }
            else if (input.Contains("how are you"))
            {
                return "I'm just a bot, but i'm doing great! what about you?";
            }
            else if (input.Contains("fine") || input.Contains("good") || input.Contains("okay"))
            {
                return "That's good, How can i assist you today? ";
            }
            else if (chatbotQA.TryGetValue(input, out string response))
            {
                return response;
            }
            else
            {
                return "i don't think i understand, could you please paraphrase?";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupportBot
{
    using System;
    using System.Collections.Generic;

    class Chatbot
    {
      
        public void RespondToQuery(string query)
        {
            Console.WriteLine($" Chatbot Response: Thank you for your query. We will get back to you soon!");
        }

        // 2. Respond to Priority Queries
        public void RespondToQuery(string query, bool isPriority)
        {
            if (isPriority)
            {
                Console.WriteLine($" Priority Query Received! Response: We are working on your issue urgently.");
            }
            else
            {
                RespondToQuery(query); 
            }
        }

        // 3. Respond to Multi-Language Queries
        public void RespondToQuery(string query, string language)
        {
            Dictionary<string, string> responses = new Dictionary<string, string>()
        {
            {"English", "Thank you for reaching out! How can we assist you?"},
            {"French", "Merci de nous contacter! Comment pouvons-nous vous aider?"},
            {"Hindi", "धन्यवाद! हम आपकी कैसे सहायता कर सकते हैं?"},
            {"German", "Danke, dass Sie uns kontaktiert haben! Wie können wir Ihnen helfen?"}
        };

            if (responses.ContainsKey(language))
            {
                Console.WriteLine($"Chatbot Response ({language}): {responses[language]}");
            }
            else
            {
                Console.WriteLine($"🌍 Chatbot Response: Sorry, we do not support {language}. Defaulting to English.");
                RespondToQuery(query);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Chatbot chatbot = new Chatbot();

            Console.WriteLine("Automated Chatbot Responses:");

            
            chatbot.RespondToQuery("What are your working hours?");
            chatbot.RespondToQuery("My order is missing!", true);
            chatbot.RespondToQuery("Can you help me?", "French");
            

        }
    }

}

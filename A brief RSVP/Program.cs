using System;

namespace A_brief_RSVP
{
    class Program
    {
        static string[] rsvps = new string[10];
        static int count = 0;
        static string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
        
        static void Main(string[] args)
        {
            RSVP("Rebecca", 3, "milk", true);
            // Named arguments
            RSVP(name: "Linh", partySize: 2, inviteOnly: false, allergies: "none");
            // It isn't necessary to name all of the arguments.
            // Named arguments are also valid as long as they're not followed by any positional arguments.
            RSVP("Tony", partySize: 1, allergies: "jackfruit", true);
            // The unnamed argument Tony is a positional argument, and must appear in the matching position.
            RSVP("Nadia", partySize: 2);
            RSVP("Noor");
            RSVP("Jonte", 4, "stone fruit", false);
            ShowRSVPs();
        }
        static void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
        {
            if (inviteOnly)
            {
                bool found = false;
                foreach (var item in guestList)
                {
                    if (item.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Sorry, {name} is not on the guest list here..!");
                    return;
                }
            }
            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \t Allergies: {allergies}";
            count++;
        }
        static void ShowRSVPs()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nTotal RSVPs::");
            Console.ResetColor();
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(rsvps[i]);
            }
            System.Console.WriteLine();
        }
    }
}
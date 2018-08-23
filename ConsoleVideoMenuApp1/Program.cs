using System;

namespace ConsoleVideoMenuApp1
{
    class Program
    {
        static string[] genreItems =
        {
            "Action",
            "Horror",
            "Comedy",
            "Drama",
            "Romance"
        };
        static void Main(string[] args)
        {
            string[] menuItems =
            {
                "List Videos",
                "Add new Video",
                "Edit existing Video",
                "Delete a Video",
                "List Genres",
                "Exit"
            };
            
            var selection = ShowMenu(menuItems);

            while (selection != 6)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("List Videos");
                        break;
                    case 2:
                        Console.WriteLine("Add new Video");
                        NewVideo();
                        break;
                    case 3:
                        Console.WriteLine("Edit existing Video");
                        break;
                    case 4:
                        Console.WriteLine("Delete a Video");
                        break;
                    case 5:
                        Console.WriteLine("List Genres");
                        ListGenres(genreItems);
                        break;
                    default:
                        break;
                }
                selection = ShowMenu(menuItems);
                Console.Clear();
            }
            Console.WriteLine("Closing app");
            Console.ReadLine();
        }

        private static void ListGenres(string[] genreItems)
        {
            for (int j = 0; j < genreItems.Length; j++)
            {
                Console.WriteLine((j + 1) + ":" + genreItems[j]);
            }
        }

        private static void NewVideo()
        {
            Console.WriteLine("Please input Video name");
            Console.ReadLine();
            Console.WriteLine("Please select Genere");
            ListGenres(genreItems);
            Console.ReadLine();
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("");
            Console.WriteLine("Select command");
            Console.WriteLine("-----------------------------\n");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)||selection < 1 || selection > 6)
            {
                Console.WriteLine("Please input a valid command");
            }
            return selection;
        }
    }
}

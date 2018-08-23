using System;

namespace ConsoleVideoMenuApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems =
            {
                "List Videos",
                "Add new Video",
                "Edit existing Video",
                "Delete a Video",
                "Add new Genre",
                "Edit existing Genre",
                "Delete Genre",
                "List Genres",
                "Exit"
            };

            var selection = ShowMenu(menuItems);

            while (selection != 9)
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
                        Console.WriteLine("Add new Genre");
                        break;
                    case 6:
                        Console.WriteLine("Edit existing Genre");
                        break;
                    case 7:
                        Console.WriteLine("Delete Genre");
                        break;
                    case 8:
                        Console.WriteLine("List Genres");
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

        private static void NewVideo()
        {
            Console.WriteLine("Please input Video name");
            Console.ReadLine();
            Console.WriteLine("Please select Genere");
            Console.ReadLine();
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select command");
            Console.WriteLine("-----------------------------\n");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)||selection < 1 || selection > 9)
            {
                Console.WriteLine("Please input a valid command");
            }
            return selection;
        }
    }
}

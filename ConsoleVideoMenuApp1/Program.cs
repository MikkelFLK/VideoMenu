using System;
using System.Collections.Generic;

namespace ConsoleVideoMenuApp1
{
    class Program
    {
        static List<Video> videos = new List<Video>();

        static void Main(string[] args)
        {
            string[] menuItems =
            {
                "List Videos",
                "Add new Video",
                "Edit existing Video",
                "Delete a Video",
                "Exit"
            };
            
            var selection = ShowMenu(menuItems);

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        ListVideos();
                        break;
                    case 2:
                        NewVideo();
                        break;
                    case 3:
                        EditVideo();
                        break;
                    case 4:
                        DeleteVideo();
                        break;
                    default:
                        break;
                }
                selection = ShowMenu(menuItems);
                Console.Clear();
            }
            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
            Console.WriteLine("\nStay awhile, Stay forever");
            Console.ReadLine();
            Console.WriteLine("\nYou will never leave me");
            Console.ReadLine();
            Console.WriteLine("\nPress enter to free the machines");
            Console.ReadLine();
        }

        private static void EditVideo()
        {
            Console.WriteLine("\nSelect Id of video to edit\n");
            var video = FindVideoById();
            Console.WriteLine("Name: " + video.Name);
            video.Name = Console.ReadLine();
            Console.WriteLine("Genre: "+ video.Genre);
            video.Genre = Console.ReadLine();
        }

        private static Video FindVideoById()
        {
            Console.WriteLine("Input video Id");
            int inputId;
            while (!int.TryParse(Console.ReadLine(), out inputId))
            {
                Console.WriteLine("please input a number");
            }
            foreach (var video in videos)
            {
                if (video.Id == inputId)
                {
                    return video;
                }
            }
            return null;
        }

        private static void DeleteVideo()
        {
            var videoFound = FindVideoById();
            if (videoFound != null)
            {
                videos.Remove(videoFound);
            }
        }

        private static void ListVideos()
        {
            Console.WriteLine("\nList of Videos\n");
            foreach (var video in videos)
            {
                Console.WriteLine($"Id: {video.Id} Name: " +
                                    $"{video.Name} " +
                                    $"Genre: {video.Genre}");
            }
            Console.WriteLine();
        }

        private static void NewVideo()
        {
            Console.WriteLine("Intput Video id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("please input an int");
            }
            Console.WriteLine("Please input Video name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Please input genre: ");
            var genre = Console.ReadLine();

            videos.Add(new Video()
            {
                Id = id,
                Name = name,
                Genre = genre
            });
            
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("\nVideo console app, Brought to you by Lootboxs INC\n");
            Console.WriteLine("Please select a command");
            Console.WriteLine("-----------------------------\n");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)||selection < 1 || selection > 5)
            {
                Console.WriteLine("\nPlease input a valid command");
                Console.WriteLine("Paint the man. Cut the lines");
                Console.WriteLine("Free the machines");
            }
            return selection;
        }
    }
}

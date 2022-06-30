using System;
using System.Collections.Generic;
using BonteBeestenBoel.Workers;

namespace BonteBeestenBoel
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create worker
            
            // TODO: Create activities
            
            // TODO: Add correct arguments
            DisplayWorkers(null);
            DisplayPlannedActivities(null);
            DisplayChildCapacity();
        }

        static List<Worker> CreateWorkers()
        {
            List<Worker> workers = new List<Worker>();
            
            while (true)
            {
                Console.WriteLine("Worker types:");
                Console.WriteLine("1: Animal Caretaker");
                Console.WriteLine("2: Cook & Baker");
                Console.WriteLine("3: Arts & Crafter");
                Console.WriteLine("0: Stop making workers.");
                Console.Write("Type > ");
                
                int typeWorker = int.Parse(Console.ReadLine());
                
                if(typeWorker == 0) break;
                
                Console.Write("First Name > ");
                string firstName = Console.ReadLine();
                
                Console.Write("Last Name > ");
                string lastName = Console.ReadLine();
                
                Console.Write("Fulltime? > ");
                bool fullTime = Console.ReadLine().ToLower() == "yes";

                // TODO: Add worker to workers list.
            }

            return workers;
        }
        
        static void DisplayWorkers(List<Worker> workers)
        {
            // THIS METHOD CANNOT BE CHANGED!
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
        }

        static void DisplayPlannedActivities(List<PlannedActivity> activities)
        {
            // THIS METHOD CANNOT BE CHANGED!
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.ToString());
                Console.WriteLine();
            }
        }

        static void DisplayChildCapacity( /* VUL ARGUMENTEN AAN*/)
        {
            // Hier moet geen gebruik gemaakt worden van een ToString override.
            // TODO
        }
    }
}
using System;
using System.Collections.Generic;
using BonteBeestenBoel.Activities;
using BonteBeestenBoel.Workers;

namespace BonteBeestenBoel
{
    class Program
    {
        static void Main(string[] args)
        {
            //var workers = CreateWorkers();
            var workers = GenerateWorkers();
            var activities = GenerateActivities();

            var planning = Plan(workers, activities);

            DisplayWorkers(workers);
            DisplayPlannedActivities(planning);
            DisplayChildCapacity(planning);
        }

        static List<PlannedActivity> Plan(List<Worker> workers, List<IActivity> activities)
        {
            List<PlannedActivity> planned = new List<PlannedActivity>();

            foreach (var worker in workers)
            {
                int spentTime = 0;
                int maxTime = worker.StopHour - worker.StartHour;
                
                while (spentTime < maxTime)
                {
                    foreach (var activity in activities)
                    {
                        if (!worker.CanPerformActivity(activity)) continue;
                        
                        if (activity is LimitedActivity || activity is LimitedInfiniteActivity)
                        {
                            var limAct = activity as LimitedActivity;
                            if(limAct.Max <= limAct.Performed) continue;
                            
                            limAct.Performed++;
                        }
                        
                        planned.Add(new PlannedActivity()
                        {
                            Activity = activity,
                            StartHour = spentTime + worker.StartHour,
                            Worker = worker
                        });

                        spentTime += activity.Duration;
                    }
                }
            }

            return planned;
        }

        static List<IActivity> GenerateActivities()
        {
            var list = new List<IActivity>();
            
            list.Add(new LimitedActivity()
            {
                Capacity = 30,
                Category = Category.AnimalCareTaker,
                Duration = 2,
                Max = 2,
                Name = "Dieren voederen"
            });
            
            list.Add(new LimitedActivity()
            {
                Capacity = 10,
                Category = Category.AnimalCareTaker,
                Duration = 2,
                Max = 1,
                Name = "Schapen scheren"
            });
            
            list.Add(new Activity()
            {
                Capacity = 30,
                Category = Category.AnimalCareTaker,
                Duration = 2,
                Name = "Diertjes Aaien"
            });
            
            list.Add(new Activity()
            {
                Capacity = 20,
                Category = Category.CookBaker,
                Duration = 1,
                Name = "Boter maken"
            });
            
            list.Add(new Activity()
            {
                Capacity = 20,
                Category = Category.CookBaker,
                Duration = 1,
                Name = "Slagroom maken"
            });
            
            list.Add(new LimitedInfiniteActivity()
            {
                Category = Category.CookBaker,
                Duration = 1,
                Max = 1,
                Name = "Boter maken"
            });
            
            list.Add(new Activity()
            {
                Capacity = 10,
                Category = Category.ArtsCrafter,
                Duration = 3,
                Name = "Beestjes maken"
            });
            
            list.Add(new Activity()
            {
                Capacity = 10,
                Category = Category.ArtsCrafter,
                Duration = 2,
                Name = "Breien 101"
            });
            
            list.Add(new InfiniteActivity()
            {
                Category = Category.ArtsCrafter,
                Duration = 1,
                Name = "1 2 3 4 Hoedjes maken van papier"
            });
            
            return list;
        }

        static List<Worker> GenerateWorkers()
        {
            var list = new List<Worker>();
            
            list.Add(new AnimalCaretaker("Bob", "AN"));
            list.Add(new AnimalCaretaker("Charlie", "AN"));
            
            list.Add(new ArtsCrafter("Lisa", "AC", true));
            list.Add(new ArtsCrafter("Linda", "AC", true));
            list.Add(new ArtsCrafter("Lieve", "AC", false));
            
            list.Add(new CookBaker("Mieke", "C", true));
            list.Add(new CookBaker("Miranda", "C", true));
            list.Add(new CookBaker("Maartje", "C", false));

            return list;
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

                Worker worker;
                switch (typeWorker)
                {
                    case 1:
                        worker = new AnimalCaretaker(firstName, lastName);
                        break;
                    case 2:
                        worker = new CookBaker(firstName, lastName, fullTime);
                        break;
                    case 3:
                        worker = new ArtsCrafter(firstName, lastName, fullTime);
                        break;

                    default:
                        throw new ArgumentException("Invalid worker type!");
                }
                
                workers.Add(worker);
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

        static void DisplayChildCapacity(List<PlannedActivity> activities)
        {
            for (int hour = 8; hour < 16; hour++)
            {
                int children = 0;
                bool minimum = false;
                
                foreach (var activity in activities)
                {
                    if (activity.StartHour <= hour && activity.Activity.Duration + activity.StartHour > hour)
                    {
                        children += activity.Activity.Capacity;
                        if (activity.Activity is InfiniteActivity || activity.Activity is LimitedInfiniteActivity)
                        {
                            minimum = true;
                        }
                    }
                }

                if (!minimum)
                {
                    Console.WriteLine(hour.ToString() + " - " + (hour + 1).ToString() + "u: " + children.ToString() + " kinderen");
                }
                else
                {
                    Console.WriteLine(hour.ToString() + " - " + (hour + 1).ToString() + "u: minstens " + children.ToString() + " kinderen");
                }
            }
        }
    }
}
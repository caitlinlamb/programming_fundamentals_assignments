namespace programming_fundamentals_assignments
{
    using System.Diagnostics;
    using System.Security.Cryptography.X509Certificates;
    using System.Timers;

    internal class Program
    {
        //creating timer objects
        public static Timer car_timer = new Timer(1500);
        public static Timer console_refresh_timer = new Timer(2000); //change bak to 100

        public static Stopwatch p1_fuelling_timer = new Stopwatch();

        public static Pump p1 = new Pump();
        public static Pump p2 = new Pump();
        public static Pump p3 = new Pump();
        public static Pump p4 = new Pump();
        public static Pump p5 = new Pump();
        public static Pump p6 = new Pump();
        public static Pump p7 = new Pump();
        public static Pump p8 = new Pump();
        public static Pump p9 = new Pump();


        public static int create_new_car = 0;
        public static int total_fuelled = 0;
        //initalising vehicle queue list
        public static Queue<object> vehicle_queue = new Queue<object>();

        static void Main(string[] args) {

            //console refresh timer
            console_refresh_timer.Elapsed += Console_refresh_timer_Elapsed;
            console_refresh_timer.Enabled = true;
            console_refresh_timer.AutoReset = true;
            console_refresh_timer.Start();

            //car timer
            car_timer.Elapsed += Car_timer_Elapsed;
            car_timer.Enabled = true;
            car_timer.AutoReset = true;
            car_timer.Start();


            Console.ReadLine();


        }

      

        private static void Console_refresh_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Console.Clear();

            Console.WriteLine(vehicle_queue.Count);
            Console.WriteLine("**Press pump number to fuel waiting vehicle**");
            Console.WriteLine("\n");
            Console.WriteLine($"L1:   P1: {p1.Status}   P2: {p2.Status}   P3: {p3.Status}");
            Console.WriteLine($"L2:   P4: {p4.Status}   P5: {p5.Status}   P6: {p6.Status}");
            Console.WriteLine($"L3:   P7: {p7.Status}   P8: {p8.Status}   P9: {p9.Status}");

            Console.WriteLine("Litres sold: ");
            Console.WriteLine("Cost: ");
            Console.WriteLine("1%: ");
            Console.WriteLine($"Vehicles fuelled: {total_fuelled}");
            Console.WriteLine("Left early: ");
        }

    
        private static void Car_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {

            //Vehicle vehicle = new Vehicle();
            //vehicle_queue.Enqueue(vehicle);

            //if (vehicle_queue.Count > 0)
            //{
            //    if (p1.Status == "avail")
            //    {
            //        vehicle_queue.Dequeue();
            //        p1.fuel(p1_fuelling_timer);
                    
                }
                //else if (p2.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p2.fuel(p2);
                //}
                //else if (p3.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p3.fuel(p3);
                //}
                //else if (p4.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p4.fuel(p4);
                //}
                //else if (p5.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p5.fuel(p5);
                //}
                //else if (p6.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p6.fuel(p6);
                //}
                //else if (p7.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p7.fuel(p7);
                //}
                //else if (p8.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p8.fuel(p8);
                //}
                //else if (p9.Status == "avail")
                //{
                //    vehicle_queue.Dequeue();
                //    p9.fuel(p9);
                //}
            }
                

        }
    


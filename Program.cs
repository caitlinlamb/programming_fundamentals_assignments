namespace programming_fundamentals_assignments
{
    using System.Security.Cryptography.X509Certificates;
    using System.Timers;

    internal class Program
    {
        //creating timer objects
        public static Timer car_timer = new Timer(1500);
        public static Timer fuelling_timer = new Timer(8000);
        public static Timer console_refresh_timer = new Timer(500);

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
        //initalising vehicle queue list
        public static Queue<object> vehicle_queue = new Queue<object>();





        static void Main(string[] args)
        {

            //car timer
            car_timer.Elapsed += Car_timer_Elapsed;
            car_timer.Enabled = true;
            car_timer.AutoReset = true;
            car_timer.Start();

            //console refresh timer
            console_refresh_timer.Elapsed += Console_refresh_timer_Elapsed;
            car_timer.Enabled = true;
            car_timer.AutoReset = true;
            car_timer.Start();

            //fuelling timer
            fuelling_timer.Elapsed += Fuelling_timer_Elapsed;
            car_timer.Enabled = true;
            car_timer.AutoReset = true;
          



            ConsoleKeyInfo pump = Console.ReadKey();

            if (vehicle_queue.Count != 0) {
                if (pump.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("key logged!");
                    p1.fuel();
                    fuelling_timer.Start();
                }

            }

            Console.ReadLine();


        }

        private static void Console_refresh_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {


        }

        private static void Fuelling_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {

        }

        private static void Car_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
           
            Vehicle vehicle = new Vehicle();
            vehicle_queue.Enqueue(vehicle);
            Console.WriteLine("new vehicle has been queued");

            Console.WriteLine("**Press pump number to fuel waiting vehicle**");
            Console.WriteLine("\n");
            Console.WriteLine($"L1:   P1: {p1.Status}   P2: {p2.Status}   P3: {p3.Status}");
            Console.WriteLine($"L2:   P4: {p4.Status}   P5: {p5.Status}   P6: {p6.Status}");
            Console.WriteLine($"L3:   P7: {p7.Status}   P8: {p8.Status}   P9: {p9.Status}");

            Console.WriteLine("Litres sold: ");
            Console.WriteLine("Cost: ");
            Console.WriteLine("1%: ");
            Console.WriteLine("Vehicles fuelled: ");
            Console.WriteLine("Left early: ");
            


        }
    }
}

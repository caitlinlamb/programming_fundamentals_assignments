namespace programming_fundamentals_assignments
{
    using System.Security.Cryptography.X509Certificates;
    using System.Timers;

    internal class Program
    {

        public static Timer car_timer = new Timer(1500);
        public static Timer fuelling_timer = new Timer(8000);
        public static int create_new_car = 0;
        public static Queue<object> vehicle_queue = new Queue<object>();

        static void Main(string[] args)
        {
           
            car_timer.Elapsed += Car_timer_Elapsed;
            car_timer.Enabled = true;
            car_timer.AutoReset = true;
            car_timer.Start();

            fuelling_timer.Elapsed += Fuelling_timer_Elapsed;
            car_timer.Enabled = true;
            car_timer.AutoReset = true;
           
            

            Pump p1 = new Pump();
            Pump p2 = new Pump();
            Pump p3 = new Pump();
            Pump p4 = new Pump();
            Pump p5 = new Pump();
            Pump p6 = new Pump();
            Pump p7 = new Pump();
            Pump p8 = new Pump();
            Pump p9 = new Pump();


            Timer carTimer = new Timer(8000);

            Console.WriteLine("**Press pump number to fuel waiting vehicle**");
            Console.WriteLine("\n");
            Console.WriteLine($"L1:   P1: {p1.status}   P2: {p2.status}   P3: {p3.status}");
            Console.WriteLine($"L2:   P4: {p4.status}   P5: {p5.status}   P6: {p6.status}");
            Console.WriteLine($"L3:   P7: {p7.status}   P8: {p8.status}   P9: {p9.status}");


            Console.ReadKey();


        }

        private static void Fuelling_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            
        }

        private static void Car_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle_queue.Enqueue(vehicle);
            Console.WriteLine("new vehicle has been queued");
        }
    }
}

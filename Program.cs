namespace programming_fundamentals_assignments
{
    using System.Diagnostics;
    using System.Security.Cryptography.X509Certificates;
    using System.Timers;

    

    internal class Program
    {

        public static Timer create_car = new Timer(1500);
        public static Queue<object> vehicle_queue = new Queue<object>();

        public static Timer fuelling_timer = new Timer(8000);

        public static Pump p1 = new Pump();
        public static Pump p2 = new Pump();
        public static Pump p3 = new Pump();
        public static Pump p4 = new Pump();
        public static Pump p5 = new Pump();
        public static Pump p6 = new Pump();
        public static Pump p7 = new Pump();
        public static Pump p8 = new Pump();
        public static Pump p9 = new Pump();

        public static void console_text()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.Clear();
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

        public static void detect_key() { 
        while (true){
        {

            if (vehicle_queue.Count != 0)
            {

                ConsoleKeyInfo pump = Console.ReadKey();

                if (pump.Key == ConsoleKey.D1)
                {
                    vehicle_queue.Dequeue();
                    p1.fuel();


                }
                else if (pump.Key == ConsoleKey.D2)
                {
                    vehicle_queue.Dequeue();
                    p2.fuel();

                }
                else if (pump.Key == ConsoleKey.D3)
                {
                    vehicle_queue.Dequeue();
                    p3.fuel();

                }
                else if (pump.Key == ConsoleKey.D4)
                {
                    vehicle_queue.Dequeue();
                    p4.fuel();

                }
                else if (pump.Key == ConsoleKey.D5)
                {
                    vehicle_queue.Dequeue();
                    p5.fuel();

                }
                else if (pump.Key == ConsoleKey.D6)
                {
                    vehicle_queue.Dequeue();
                    p6.fuel();

                }
                else if (pump.Key == ConsoleKey.D7)
                {
                    vehicle_queue.Dequeue();
                    p7.fuel();

                }
                else if (pump.Key == ConsoleKey.D8)
                {
                    vehicle_queue.Dequeue();
                    p8.fuel();

                }
                else if (pump.Key == ConsoleKey.D9)
                {
                    vehicle_queue.Dequeue();
                    p9.fuel();

                }

            }
        }


        }
            
    }

        static void Main(string[] args)
        {
            create_car.Elapsed += Create_car_Elapsed;
            create_car.Enabled = true;
            create_car.Start();
            create_car.AutoReset = true;

            Thread console_update = new Thread(console_text);
            console_update.Start();

            Thread key_detector = new Thread(detect_key);
            key_detector.Start();
        }

        public static void Create_car_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle_queue.Enqueue(vehicle);
            Console.WriteLine(vehicle_queue.Count);
        }
    }
}
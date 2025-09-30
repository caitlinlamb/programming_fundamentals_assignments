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

        //matrix
        public static Object[,] pump_status = new Object[9, 2]
        {
            {p1, 0},
            {p2, 0},
            {p3, 0},
            {p4, 0},
            {p5, 0},
            {p6, 0},
            {p7, 0},
            {p8, 0},
            {p9, 0}
        };

        internal class Pump
        {

            private string status = "avail"; // field
            public string Status   // property
            {
                get { return status; }
                set { status = value; }
            }

            public void fuel(object vehicle, object pump)
            {
                status = "busy ";
                fuelling_timer.Start();
                //removes object from end of vehicle waiting queue and adds it to currenyl fuelling list. need to ammend to make it alignwith pump number
                if (pump == p1)
                {
                    pump_status[0, 1] = vehicle;
                    pump_status[0, 0] = pump;
                }
                else if (pump == p2)
                {
                    pump_status[1, 1] = vehicle;
                    pump_status[1, 0] = pump;
                }
                else if (pump == p3)
                {
                    pump_status[2, 1] = vehicle;
                    pump_status[2, 0] = pump;
                }
                else if (pump == p4)
                {
                    pump_status[3, 1] = vehicle;
                    pump_status[3, 0] = pump;
                }
                else if (pump == p5)
                {
                    pump_status[4, 1] = vehicle;
                    pump_status[4, 0] = pump;
                }
                else if (pump == p6)
                {
                    pump_status[5, 1] = vehicle;
                    pump_status[5, 0] = pump;
                }
                else if (pump == p7)
                {
                    pump_status[6, 1] = vehicle;
                    pump_status[6, 0] = pump;
                }
                else if (pump == p8)
                {
                    pump_status[7, 1] = vehicle;
                    pump_status[7, 0] = pump;
                }
                else if (pump == p9)
                {
                    pump_status[8, 1] = vehicle;
                    pump_status[8, 0] = pump;
                }


            }



        }







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
                    p1.fuel(vehicle_queue.Dequeue(), p1);
                    


                }
                else if (pump.Key == ConsoleKey.D2)
                {
                    vehicle_queue.Dequeue();
                    p2.fuel(vehicle_queue.Dequeue(), p2);

                }
                else if (pump.Key == ConsoleKey.D3)
                {
                    vehicle_queue.Dequeue();
                    p3.fuel(vehicle_queue.Dequeue(), p3);

                }
                else if (pump.Key == ConsoleKey.D4)
                {
                    vehicle_queue.Dequeue();
                    p4.fuel(vehicle_queue.Dequeue(), p4);

                }
                else if (pump.Key == ConsoleKey.D5)
                {
                    vehicle_queue.Dequeue();
                    p5.fuel(vehicle_queue.Dequeue(), p5);

                }
                else if (pump.Key == ConsoleKey.D6)
                {
                    vehicle_queue.Dequeue();
                    p6.fuel(vehicle_queue.Dequeue(), p6);

                }
                else if (pump.Key == ConsoleKey.D7)
                {
                    vehicle_queue.Dequeue();
                    p7.fuel(vehicle_queue.Dequeue(), p7);

                }
                else if (pump.Key == ConsoleKey.D8)
                {
                    vehicle_queue.Dequeue();
                    p8.fuel(vehicle_queue.Dequeue(), p8);

                }
                else if (pump.Key == ConsoleKey.D9)
                {
                    vehicle_queue.Dequeue();
                    p9.fuel(vehicle_queue.Dequeue(), p9);

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

            fuelling_timer.Elapsed += Fuelling_timer_Elapsed; ;
            create_car.Enabled = true;

            Thread console_update = new Thread(console_text);
            console_update.Start();

            Thread key_detector = new Thread(detect_key);
            key_detector.Start();


        }

        private static void Fuelling_timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            //dequeue here?
        }

        public static void Create_car_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle_queue.Enqueue(vehicle);
            Console.WriteLine(vehicle_queue.Count);
        }
    }
}
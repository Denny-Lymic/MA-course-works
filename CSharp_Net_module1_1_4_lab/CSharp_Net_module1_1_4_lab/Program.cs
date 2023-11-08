using System;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType

        enum ComputerType
        {
            Desktop,
            Laptop,
            Server
        }

        // 2) declare struct Computer

        struct Computer
        {
            public ComputerType type;
            public int CPUCores;
            public float CPUFrequency;
            public int memory;
            public int storage;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)

            Computer[][] departments = new Computer[4][];

            // 4) set the size of every array in jagged array (number of computers)

            departments[0] = new Computer[5];
            departments[1] = new Computer[3];
            departments[2] = new Computer[5];
            departments[3] = new Computer[4];

            // 5) initialize array
            // Note: use loops and if-else statements


            for (int i = 0; i < departments.GetLength(0); i++) 
            {
                for(int j = 0; j < departments[i].Length; j++)
                {
                    if((i == 0 && j < 2) || (i == 2 && j < 3) || (i == 3 && j < 1)) //Desktops
                    {
                        departments[i][j].type = ComputerType.Desktop;
                        departments[i][j].CPUCores = 4;
                        departments[i][j].CPUFrequency = 2.5f;
                        departments[i][j].memory = 6;
                        departments[i][j].storage = 500;
                    }
                    else if ((i == 0 && j >= 2 && j < 4) || (i == 1 && j < 3) || (i == 2 && j >= 3 && j < 5) || (i == 3 && j == 1)) //Laptops
                    {
                        departments[i][j].type = ComputerType.Laptop;
                        departments[i][j].CPUCores = 2;
                        departments[i][j].CPUFrequency = 1.7f;
                        departments[i][j].memory = 4;
                        departments[i][j].storage = 250;
                    }
                    else //Servers
                    {
                        departments[i][j].type = ComputerType.Server;
                        departments[i][j].CPUCores = 8;
                        departments[i][j].CPUFrequency = 3.0f;
                        departments[i][j].memory = 16;
                        departments[i][j].storage = 2000;
                    }
                }
            }

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            int desktops = 0;
            int laptops = 0;
            int servers = 0;
            int computers = 0;

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].type == ComputerType.Desktop) desktops ++;
                    if (departments[i][j].type == ComputerType.Laptop) laptops++;
                    if (departments[i][j].type == ComputerType.Server) servers++;
                    computers++;
                }
            }

            Console.WriteLine("Count of desktops - " + desktops);
            Console.WriteLine("Count of laptops - " + laptops);
            Console.WriteLine("Count of servers - " + servers);
            Console.WriteLine("Count of all computers - " + computers);
            Console.WriteLine();

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            int largestHDDindex;

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                largestHDDindex = 0;
                for (int j = 1; j < departments[i].Length; j++)
                {
                    if (departments[i][j].storage > departments[i][largestHDDindex].storage) largestHDDindex = j;
                }
                Console.WriteLine(i + 1 + " department - " + departments[i][largestHDDindex].type + " has the lagrest storage.");
            }


            Console.WriteLine();

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            int worstCPUindex;
            int worstMemoryIndex;

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                worstCPUindex = 0;
                worstMemoryIndex = 0;
                for (int j = 1; j < departments[i].Length; j++)
                {
                    if (departments[i][j].CPUCores < departments[i][worstCPUindex].CPUCores) worstCPUindex = j;
                    if (departments[i][j].memory < departments[i][worstMemoryIndex].memory) worstMemoryIndex = j;
                }
                Console.WriteLine(i + 1 + " department - " + departments[i][worstCPUindex].type + " has the worst CPU.");
                Console.WriteLine(i + 1 + " department - " + departments[i][worstMemoryIndex].type + " has the worst memory.");
            }

            Console.WriteLine();

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].type == ComputerType.Desktop)
                        departments[i][j].memory = 8;
                }
            }

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                if (i == 0) Console.WriteLine("First department");
                if (i == 1) Console.WriteLine("Second department");
                if (i == 2) Console.WriteLine("Third department");
                if (i == 3) Console.WriteLine("Forth department");
                for (int j = 0; j < departments[i].Length; j++)
                {
                    Console.Write(departments[i][j].type + "s: (" + departments[i][j].CPUCores + " cores, " + departments[i][j].CPUFrequency + " CPUFrequency, " + departments[i][j].memory + "GB memory, " + departments[i][j].storage + "GB storage)");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}

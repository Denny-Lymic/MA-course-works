using System;
using System.Diagnostics.Eventing.Reader;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        static void Info(int desktopCount, int laptopCount, int serverCount)
        {
            if (desktopCount != 0)
                Console.Write(desktopCount + " desktop(s) ");
            if (laptopCount != 0)
                Console.Write(laptopCount + " laptop(s) ");
            if (serverCount != 0)
                Console.Write(serverCount + " server(s) ");
        }

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
            Computer desktop = new Computer()
            {
                type = ComputerType.Desktop,
                CPUCores = 4,
                CPUFrequency = 2.5f,
                memory = 6,
                storage = 500,
            };
            Computer laptop = new Computer()
            {
                type = ComputerType.Laptop,
                CPUCores = 2,
                CPUFrequency = 1.7f,
                memory = 4,
                storage = 250,
            };
            Computer server = new Computer()
            {
                type = ComputerType.Server,
                CPUCores = 8,
                CPUFrequency = 3.0f,
                memory = 16,
                storage = 2000,
            };

            int[,] settingMatrix = new int[,] 
            { 
                { 2, 2, 1 }, // 2d, 2l, 1s
                { 0, 3, 0 }, // 3l
                { 3, 2, 0 }, // 3d, 2l
                { 1, 1, 2 }  // 1d, 1l, 2s
            };
            int currJ;

            // 4) set the size of every array in jagged array (number of computers)

            departments[0] = new Computer[5];
            departments[1] = new Computer[3];
            departments[2] = new Computer[5];
            departments[3] = new Computer[4];

            // 5) initialize array
            // Note: use loops and if-else statements

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                currJ = 0;
                for (int j = 0; j < settingMatrix[i, 0]; j++)
                {
                    departments[i][currJ] = desktop;
                    currJ++;
                }
                for (int j = 0; j < settingMatrix[i, 1]; j++)
                {
                    departments[i][currJ] = laptop;
                    currJ++;
                }
                for (int j = 0; j < settingMatrix[i, 2]; j++)
                {
                    departments[i][currJ] = server;
                    currJ++;
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
                    if (departments[i][j].type == ComputerType.Desktop) desktops++;
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

            int desktopCount, laptopCount, serverCount;

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                desktopCount = 0; laptopCount = 0; serverCount = 0;
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].type == ComputerType.Desktop) desktopCount++;
                    if (departments[i][j].type == ComputerType.Laptop) laptopCount++;
                    if (departments[i][j].type == ComputerType.Server) serverCount++;
                }
                if (i == 0)
                {
                    Console.Write("First department - ");
                    Info(desktopCount, laptopCount, serverCount);
                }
                if (i == 1)
                {
                    Console.Write("Second department - ");
                    Info(desktopCount, laptopCount, serverCount);
                }
                if (i == 2)
                {
                    Console.Write("Third department - ");
                    Info(desktopCount, laptopCount, serverCount);
                }
                if (i == 3)
                {
                    Console.Write("Forth department - ");
                    Info(desktopCount, laptopCount, serverCount);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}

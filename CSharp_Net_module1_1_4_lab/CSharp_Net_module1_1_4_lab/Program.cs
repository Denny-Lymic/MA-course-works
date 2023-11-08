using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

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
            public int count;
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

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                departments[i] = new Computer[3];
            }

            // 5) initialize array
            // Note: use loops and if-else statements

            for (int i = 0; i < departments.GetLength(0); i++)
            {
                if (i == 0)
                    for (int j = 0; j < departments[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            departments[i][j].type = ComputerType.Desktop;
                            departments[i][j].count = 2;
                            departments[i][j].CPUCores = 4;
                            departments[i][j].CPUFrequency = 2.5f;
                            departments[i][j].memory = 6;
                            departments[i][j].storage = 500;
                        }
                        if (j == 1)
                        {
                            departments[i][j].type = ComputerType.Laptop;
                            departments[i][j].count = 2;
                            departments[i][j].CPUCores = 2;
                            departments[i][j].CPUFrequency = 1.7f;
                            departments[i][j].memory = 4;
                            departments[i][j].storage = 250;
                        }
                        if (j == 2)
                        {
                            departments[i][j].type = ComputerType.Server;
                            departments[i][j].count = 1;
                            departments[i][j].CPUCores = 8;
                            departments[i][j].CPUFrequency = 3.0f;
                            departments[i][j].memory = 16;
                            departments[i][j].storage = 2000;
                        }
                    }
                if (i == 1)
                    for (int j = 0; j < departments[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            departments[i][j].type = ComputerType.Desktop;
                            departments[i][j].count = 0;
                            departments[i][j].CPUCores = 4;
                            departments[i][j].CPUFrequency = 2.5f;
                            departments[i][j].memory = 6;
                            departments[i][j].storage = 500;
                        }
                        if (j == 1)
                        {
                            departments[i][j].type = ComputerType.Laptop;
                            departments[i][j].count = 3;
                            departments[i][j].CPUCores = 2;
                            departments[i][j].CPUFrequency = 1.7f;
                            departments[i][j].memory = 4;
                            departments[i][j].storage = 250;
                        }
                        if (j == 2)
                        {
                            departments[i][j].type = ComputerType.Server;
                            departments[i][j].count = 0;
                            departments[i][j].CPUCores = 8;
                            departments[i][j].CPUFrequency = 3.0f;
                            departments[i][j].memory = 16;
                            departments[i][j].storage = 2000;
                        }
                    }
                if (i == 2)
                    for (int j = 0; j < departments[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            departments[i][j].type = ComputerType.Desktop;
                            departments[i][j].count = 3;
                            departments[i][j].CPUCores = 4;
                            departments[i][j].CPUFrequency = 2.5f;
                            departments[i][j].memory = 6;
                            departments[i][j].storage = 500;
                        }
                        if (j == 1)
                        {
                            departments[i][j].type = ComputerType.Laptop;
                            departments[i][j].count = 2;
                            departments[i][j].CPUCores = 2;
                            departments[i][j].CPUFrequency = 1.7f;
                            departments[i][j].memory = 4;
                            departments[i][j].storage = 250;
                        }
                        if (j == 2)
                        {
                            departments[i][j].type = ComputerType.Server;
                            departments[i][j].count = 0;
                            departments[i][j].CPUCores = 8;
                            departments[i][j].CPUFrequency = 3.0f;
                            departments[i][j].memory = 16;
                            departments[i][j].storage = 2000;
                        }
                    }
                if (i == 3)
                    for (int j = 0; j < departments[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            departments[i][j].type = ComputerType.Desktop;
                            departments[i][j].count = 1;
                            departments[i][j].CPUCores = 4;
                            departments[i][j].CPUFrequency = 2.5f;
                            departments[i][j].memory = 6;
                            departments[i][j].storage = 500;
                        }
                        if (j == 1)
                        {
                            departments[i][j].type = ComputerType.Laptop;
                            departments[i][j].count = 1;
                            departments[i][j].CPUCores = 2;
                            departments[i][j].CPUFrequency = 1.7f;
                            departments[i][j].memory = 4;
                            departments[i][j].storage = 250;
                        }
                        if (j == 2)
                        {
                            departments[i][j].type = ComputerType.Server;
                            departments[i][j].count = 2;
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
                    if (departments[i][j].type == ComputerType.Desktop) desktops += departments[i][j].count;
                    if (departments[i][j].type == ComputerType.Laptop) laptops += departments[i][j].count;
                    if (departments[i][j].type == ComputerType.Server) servers += departments[i][j].count;
                    if (departments[i][j].count != 0) computers += departments[i][j].count;
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

            int largestHDDindex = 0;

            for (int i = 1; i < departments[0].Length; i++)
            {
                if (departments[0][i].storage > departments[0][largestHDDindex].storage) largestHDDindex = i;
            }

            Console.WriteLine(departments[0][largestHDDindex].type + " has the lagrest storage.");
            Console.WriteLine();

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            int worstCPUindex = 0;
            int worstMemoryIndex = 0;

            for (int i = 1; i < departments[0].Length; i++)
            {
                if (departments[0][i].CPUCores < departments[0][worstCPUindex].CPUCores) worstCPUindex = i;
                if (departments[0][i].memory < departments[0][worstMemoryIndex].memory) worstMemoryIndex = i;
            }

            Console.WriteLine(departments[0][worstCPUindex].type + " has the worst CPU.");
            Console.WriteLine(departments[0][worstMemoryIndex].type + " has the worst memory.");
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
                    Console.Write(departments[i][j].type + "s: count - " + departments[i][j].count + " (" + departments[i][j].CPUCores + " cores, " + departments[i][j].CPUFrequency + " CPUFrequency, " + departments[i][j].memory + "GB memory, " + departments[i][j].storage + "GB storage)");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}

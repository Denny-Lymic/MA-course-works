using Lab_5._1;
using System.Text;
// 3) create collection of computers;
// set path to file and file name

Computer[] computers = new Computer[] {
new Computer() {Cores = 4, Frequency = 4.4, Hdd = 1000, Memory = 16},
new Computer() {Cores = 4, Frequency = 4.0, Hdd = 960, Memory = 12},
new Computer() {Cores = 6, Frequency = 4.4, Hdd = 800, Memory = 32},
new Computer() {Cores = 3, Frequency = 3.6, Hdd = 500, Memory = 8},
new Computer() {Cores = 12, Frequency = 2.6, Hdd = 3000, Memory = 64},
};
InOutOperation file = new InOutOperation(@"C:\Users\denig\MA_Course_Works\Lab 5.1\", @"Text folder\", "test.txt");

do
{

    try
    {
        Console.WriteLine("1. Write and read info from file");
        Console.WriteLine("2. Write and read info from zip");
        Console.WriteLine("3. Async read info from file");       

        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                {               
                    file.WriteData(computers);
                    Console.WriteLine("Info from file:");
                    Console.WriteLine(file.ReadData());
                    break;
                }
            case 2:
                {
                    string zipPath = @"C:\Users\denig\MA_Course_Works\Lab 5.1\Text folder\zip.gz";
                    string zipInfoPath = @"C:\Users\denig\MA_Course_Works\Lab 5.1\Text folder\zipInfo.txt";
                    file.WriteZip(zipPath, computers);
                    string info = Encoding.Default.GetString(file.ReadZip(zipPath, zipInfoPath));
                    Console.WriteLine("Info from zip:");
                    Console.WriteLine(info);
                    break;
                }
            case 3:
                {
                    Task.Run(() => file.ReadAsync());
                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("*");
                        Thread.Sleep(100);
                    }
                    Console.WriteLine();
                    break;
                }
        }

        // 4) save data and read it in the seamplest way (with WriteData() and ReadData() methods)

        // 5) save data and read it with WriteZip() and ReadZip() methods
        // Note: create another file for these operations

        // 6) read info about computers asynchronously (from the 1st file)
        // While asynchronous method will be running, Main() method must print ‘*’ 

        // use 
        // collection of Task with info about computers as type to get returned data from method ReadAsync()
        // use property Result of collection of Task to get access to info about computers

        // Note:
        // print all info about computers after reading from files


        // ADVANCED:
        // 8) save data to memory stream and from memory to file
        // declare file stream and set it to null
        // call method WriteToMemory() with info about computers as parameter
        // save returned stream to file stream

        // call method WriteToFileFromMemory() with parameter of file stream
        // open file with saved data and compare it with input info
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally
    {
        Console.WriteLine("Press Spacebar to exit; press any key to continue");
    }
} while (Console.ReadKey().Key != ConsoleKey.Spacebar);

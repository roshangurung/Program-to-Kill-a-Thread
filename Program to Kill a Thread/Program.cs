using System;
using System.Threading.Tasks;
using System.Threading;
class Program
{
    static void Main(string[] args)///In this C# Program, we are creating an object ‘th’ for ThreadingClass. then we are creating a new thread named as thread1 by calling the DoStuff() function in threading class. Using while loop in Dostuff() function check the thread is still working by checking the condition of the value of ‘flag’ variable is equal to true.///
    {

        ThreadingClass th = new ThreadingClass();
        Thread thread1 = new Thread(th.DoStuff);
        thread1.Start();
        Console.WriteLine("Press any key to exit!!!");
        Console.ReadKey();
        th.Stop();
        thread1.Join();
    }
}
public class ThreadingClass///If the condition is true, then execute the statement and print the statement as Thread is Still Working. The sleep() method is used for making a thread pause for a specific period of time. Here the working of the thread is stopped when a key is pressed else the work continues//
{
    private bool flag = false;
    public void DoStuff()
    {
        while (!flag)
        {
            Console.WriteLine(" Thread is Still Working");
            Thread.Sleep(1000);
        }
    }
    public void Stop()
    {
        flag = true;
    }
}
///Output:Press any key to exit!!!
///Thread is Still Working
///Thread is Still Working
///Thread is Still Working
 
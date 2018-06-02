using System;

namespace Circulary
{
    class Program
    {
        static Random random = new Random(DateTime.Now.Millisecond);
        static List list = new List();
        static void Main(string[] args)
        {
            Simulation();
        }

        static void Simulation()
        {
            int emptyCounter, finishCounter, pendingCounter, restSteps; 
            emptyCounter = finishCounter = pendingCounter = restSteps = 0;

            for (int i = 0; i < 300; i++)
            {
                if (random.Next(100) < 35)
                    list.Add(new Process());

                if (list.Head != null)
                {
                    Process process = list.Head;
                    process.Steps--;
                    if (process.Steps == 0)
                    {
                        finishCounter++;
                        list.DeleteFirst();
                    }
                }
                else
                    emptyCounter++;
            }

            Process temp = list.DeleteFirst();
            while (temp != null)
            {
                pendingCounter++;
                restSteps += temp.Steps;
                temp = list.DeleteFirst();
            }

            Console.WriteLine(
                "Statics{0}Iterations With Empty list: {1}{2}FinishedProcesses: {3}{4}Pending Processes: {5}{6}Steps to Go: {7}{8}",
                Environment.NewLine,
                emptyCounter,
                Environment.NewLine,
                finishCounter,
                Environment.NewLine,
                pendingCounter,
                Environment.NewLine,
                restSteps,
                Environment.NewLine
            );
        }
    }
}

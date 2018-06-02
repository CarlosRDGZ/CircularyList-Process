namespace Circulary
{
    class Process
    {
        public Process Next;
        public Process Previous;
        public int Steps;
        public readonly int Pid;
        public static System.Random random = 
            new System.Random(System.DateTime.Now.Millisecond);

        public Process()
        {
            this.Steps = random.Next(4,15);
            this.Pid = System.DateTime.Now.Millisecond + random.Next(60);
        }
    }
}
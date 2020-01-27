using System;

namespace Mankind
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] studentInfoInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] workerInfoInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Student student = new Student(studentInfoInput[0], studentInfoInput[1], studentInfoInput[2]);
                Worker worker = new Worker(workerInfoInput[0], workerInfoInput[1], decimal.Parse(workerInfoInput[2]), decimal.Parse(workerInfoInput[3]));
                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.GetBaseException().Message);
            }
        }
    }
}

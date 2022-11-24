namespace TutlaneExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            if (string.IsNullOrEmpty(name))
            {
                throw new TutlaneCustomException("Name is Empty");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }
            Console.ReadLine();
        }
    }
    public class TutlaneCustomException : Exception
    {
        public TutlaneCustomException()
        {
        }
        public TutlaneCustomException(string message) : base(message)
        {
        }
        public TutlaneCustomException(string message, Exception innerexception) : base(message, innerexception)
        {
        }
    }
}
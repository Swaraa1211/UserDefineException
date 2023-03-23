namespace UserDefineException
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //int age = 17;
            int age = Convert.ToInt32(Console.ReadLine());  
            try
            {
                CheckAge(age);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
        public static void CheckAge(int age)
        {
            if (age < 18) {
                throw new MyException("Not Eligible");
            //Console.WriteLine("Not Eligible")
            //
            }
        }
        public class MyException : Exception
        {
            public MyException(string myMessage):base(myMessage) { 
            }
        }
    }
}
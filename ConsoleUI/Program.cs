using AccessModifiers;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo();
            BadClass badClass = new BadClass();

            // shouldn't be able to access this here
            badClass.creditCardNumber = "";

            // won't actually set age because out of range which is good
            badClass.Age = 150;

            
        }
    }
}
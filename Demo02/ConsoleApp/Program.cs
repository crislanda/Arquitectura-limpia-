using MyLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Secretary Maria = new Secretary();
            Maria.Name = "Maria";
            Manager Pedro = new Manager();
            Pedro.Name = "Pedro";
            Developer Emmanuel = new Developer();
            Emmanuel.Name = "Emmanuel";

            WriteEmployeeInfo(Emmanuel);
            WriteEmployeeInfo(Maria);
            WriteEmployeeInfo(Pedro);

            void WriteEmployeeInfo(Employee employee)
            {
                Console.WriteLine($"{employee.Name}: {employee.CalculateMonthlyPayment()}");
                Console.WriteLine($"Days: {employee.GetPaymentDays()}");
            }
        }
    }
}

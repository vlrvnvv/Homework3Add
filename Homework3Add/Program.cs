namespace Homework3Add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier()
            {
                Name = "Петров Петр Петрович"
            };

            Postman postman = new Postman()
            {
                Name = "Алексеев Алексей Алексеевич",
                IsBusy = true
            };

            Operator operator1 = new Operator()
            {
                Name = "Михаилов Михаил Михаилович"
            };

            PostOffice postOffice = new PostOffice();
            postOffice.AddEmployee(cashier);
            postOffice.AddEmployee(operator1);
            postOffice.AddEmployee(postman);

            postOffice.Poll();
        }
    }
}
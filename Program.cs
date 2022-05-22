using Projeto1.src;
namespace Projeto1
{
    class Program
    {
        static void Main(String[] args)
        {
            Knight Knight = new Knight("Ibga", 5, "Knight");
            Wizard wizard = new Wizard("Yen", 6, "Withe wizard");

            Console.WriteLine(Knight.Attack());
            Console.WriteLine(wizard.Attack(8));
            
        }
    }
    
}



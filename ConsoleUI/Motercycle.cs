using System;
namespace ConsoleUI
{
    public class Motercycle : Vehicle
    {
        

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Has sidecart: " + HasSideCart);
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Grrrrrrrrr");
        }
    }
}

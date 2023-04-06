using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace TugasProgram
{
    public class Processor
    {
        public string merk, tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }
    public class Amd : Processor
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }
    class Athlon : Amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    class Ryzen : Amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    public class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    public class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memaminkan game");
        }
        public class ASUS : Laptop
        {
            public ASUS()
            {
                base.merk = "ASUS";
            }
        }
        class ROG : ASUS
        {
            public ROG()
            {
                base.tipe = "ROG";
            }
        }
        class Vivobook : ASUS
        {
            public Vivobook()
            {
                base.tipe = "Vivobook";
            }
            public void Ngoding()
            {
                Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
            }
        }
        public class Lenovo : Laptop
        {
            public Lenovo()
            {
                base.merk = "Lenovo";
            }
        }
        class Legion : Lenovo
        {
            public Legion()
            {
                base.tipe = "Legion";
            }
        }
        class IdeaPad : Lenovo
        {
            public IdeaPad()
            {
                base.tipe = "IdeaPad";
            }
        }

        internal class program
        {
            static void Main(string[] args)
            {
                Laptop laptop1 = new Vivobook();
                laptop1.vga = new Nvidia();
                laptop1.processor = new CoreI5();


                Console.WriteLine(laptop1.vga.merk);
                Console.WriteLine(laptop1.processor.merk);
                Console.WriteLine(laptop1.processor.tipe + "\n");


                //laptop1.Ngoding();


                Laptop laptop2 = new IdeaPad();
                laptop2.vga = new AMD();
                laptop2.processor = new Ryzen();


                Console.WriteLine(laptop2.vga.merk);
                Console.WriteLine(laptop2.processor.merk);
                Console.WriteLine(laptop2.processor.tipe);


                laptop2.LaptopDinyalakan();
                laptop2.LaptopDimatikan();


                Predator predator = new Predator();
                predator.vga = new AMD();
                predator.processor = new CoreI7();


                Console.WriteLine("\n" + predator.vga.merk);
                Console.WriteLine(predator.processor.merk);
                Console.WriteLine(predator.processor.tipe);

                predator.BermainGame();
            }
        }
    }
}
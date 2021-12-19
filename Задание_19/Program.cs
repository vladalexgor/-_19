using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class PC
    {
        public string Code { get; set; }
        public string NamePC { get; set; }
        public string TypeCPU { get; set; }
        public int SpeedCPU { get; set; }
        public int CapacityRAM { get; set; }
        public int CapacityHD { get; set; }
        public int CapacityMemoryVC { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        //Модель компьютера характеризуется кодом и названием марки компьютера, типом процессора, частотой работы процессора, объемом оперативной памяти, объемом жесткого диска,
        //объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. Создать список, содержащий 6-10 записей с различным
        //набором значений характеристик.
        //Определить:
        //- все компьютеры с указанным процессором. Название процессора запросить у пользователя;
        //- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
        //- вывести весь список, отсортированный по увеличению стоимости;
        //- вывести весь список, сгруппированный по типу процессора;
        //- найти самый дорогой и самый бюджетный компьютер;
        //- есть ли хотя бы один компьютер в количестве не менее 30 штук?
        static void Main(string[] args)
        {
            List<PC> listPC = new List<PC>()
            {
                new PC(){Code = "001000", NamePC= "Dell", TypeCPU = "Intel Core I7", SpeedCPU = 3500, CapacityRAM = 16, CapacityHD = 256, CapacityMemoryVC = 8, Cost = 1500, Quantity = 14},
                new PC(){Code = "002100", NamePC= "Sansung", TypeCPU = "Intel Core I5", SpeedCPU = 3700, CapacityRAM = 8, CapacityHD = 128, CapacityMemoryVC = 6, Cost = 1100, Quantity = 67},
                new PC(){Code = "003460", NamePC= "Sansung", TypeCPU = "Intel Core I3", SpeedCPU = 3000, CapacityRAM = 4, CapacityHD = 512, CapacityMemoryVC = 4, Cost = 800, Quantity = 3},
                new PC(){Code = "004000", NamePC= "Apple", TypeCPU = "Apple M1", SpeedCPU = 2100, CapacityRAM = 16, CapacityHD = 256, CapacityMemoryVC = 8, Cost = 2000, Quantity = 50},
                new PC(){Code = "005100", NamePC= "Sony", TypeCPU = "Intel Core I3", SpeedCPU = 3000, CapacityRAM = 4, CapacityHD = 512, CapacityMemoryVC = 4, Cost = 1000, Quantity = 6},
                new PC(){Code = "006450", NamePC= "HP", TypeCPU = "Intel Core I5", SpeedCPU = 4000, CapacityRAM = 32, CapacityHD = 1024, CapacityMemoryVC = 10, Cost = 2500, Quantity = 120},
                new PC(){Code = "007500", NamePC= "Sony", TypeCPU = "Intel Core I7", SpeedCPU = 4200, CapacityRAM = 16, CapacityHD = 256, CapacityMemoryVC = 6, Cost = 1700, Quantity = 23},
                new PC(){Code = "008000", NamePC= "Lenovo", TypeCPU = "Intel Core I5", SpeedCPU = 3500, CapacityRAM = 8, CapacityHD = 512, CapacityMemoryVC = 8, Cost = 1500, Quantity = 1},
                new PC(){Code = "009300", NamePC= "Lenovo", TypeCPU = "Intel Core I7", SpeedCPU = 4200, CapacityRAM = 32, CapacityHD = 512, CapacityMemoryVC = 10, Cost = 3000, Quantity = 34},
                new PC(){Code = "010400", NamePC= "Apple", TypeCPU = "Apple M2", SpeedCPU = 3200, CapacityRAM = 16, CapacityHD = 256, CapacityMemoryVC = 8, Cost = 3500, Quantity = 20}
            };
            //Выводятся все компы с указанным процессором, ввод названия от пользователя:
            #region Введите название процессора
            Console.WriteLine("Введите название процессора:");
            string typeCPU = Console.ReadLine();
            List<PC> pC1 = listPC
                .Where(pc => pc.TypeCPU == typeCPU)
                .ToList();
            foreach (PC p in pC1)
            {
                Console.WriteLine($"{p.Code} {p.NamePC} {p.TypeCPU} {p.SpeedCPU} {p.CapacityRAM} {p.CapacityHD} {p.CapacityMemoryVC} {p.Cost} {p.Quantity}");
            }
            Console.WriteLine();
            #endregion
            #region Введите значение минимально требуемого объема ОЗУ
            Console.WriteLine("Введите значение минимально требуемого объема ОЗУ:");
            int capacityRAM = Convert.ToInt32(Console.ReadLine());
            List<PC> pC2 = listPC
                .Where(pc => pc.CapacityRAM >= capacityRAM)
                .ToList();
            foreach (PC p in pC2)
            {
                Console.WriteLine($"{p.Code} {p.NamePC} {p.TypeCPU} {p.SpeedCPU} {p.CapacityRAM} {p.CapacityHD} {p.CapacityMemoryVC} {p.Cost} {p.Quantity}");
            }
            Console.WriteLine();
            #endregion
            #region Список всех компов, отсортированных по увеличению стоимости
            Console.WriteLine("Список всех компов, отсортированных по увеличению стоимости:");
            List<PC> pC3 = listPC
                .OrderBy(pc => pc.Cost)
                .ToList();
            foreach (PC p in pC3)
            {
                Console.WriteLine($"{p.Code} {p.NamePC} {p.TypeCPU} {p.SpeedCPU} {p.CapacityRAM} {p.CapacityHD} {p.CapacityMemoryVC} {p.Cost} {p.Quantity}");
            }
            Console.WriteLine();
            #endregion
            #region Список всех компов, сгруппированных по типу процессора
            Console.WriteLine("Список всех компов, сгруппированных по типу процессора:");
            var pC4 = listPC
                .GroupBy(pc => pc.TypeCPU)
                .Select(t => new
                {
                    Group = t.Key,
                    Comp = t.ToList()
                });
            foreach (var g in pC4)
            {
                Console.WriteLine(g.Group);
                foreach (var p in g.Comp)
                {
                    Console.WriteLine($"   {p.Code} {p.NamePC} {p.TypeCPU} {p.SpeedCPU} {p.CapacityRAM} {p.CapacityHD} {p.CapacityMemoryVC} {p.Cost} {p.Quantity}");
                }
            }
            #endregion*/
            #region Есть ли хотя бы один компьютер в количестве не менее 30 штук
            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук:");
            var pC6 = listPC
                .Any(pc => pc.Quantity > 30);
            if (pC6)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            #endregion
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();

            /*//SQL подобный синтаксис:
            List<Door> doors = (from d in listDoor
                                where d.Material == "Дерево"
                                select d).ToList();

            //Синтаксис на основе методов расширений:
            List<Door> doors = listDoor
                .Where(d => d.Material == "Дерево")
                .ToList();

            var doors = listDoors
                where(d => d.Cost>10000)
                .Count();
            Console.WriteLine(doors);*/


            /*var doors = listDoors
                .OrderBy(d=>d.Cost)
                .ToList();*/


            /*var doors = listDoors
                .Select(d=>new
                {
                    Mater = d.Material
                    Manuf = d.Manufacturer
                })
                .Distinct()
                .ToList();

            foreach (var s in doors)
            {
                Console.WriteLine($"{s.Mater} {s.Manuf}");
            }*/

            /*foreach (Door d in doors)
            {
                Console.WriteLine($"{d.Id} {d.Width} {d.Cost}");
            }*/
        }
    }
}

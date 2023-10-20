
namespace tortiki
{
    internal class MenuShow
    {
        private int MinStrelka;
        private int MaxStrelka;
        public MenuShow(int min, int max)
        {
            MinStrelka = min;
            MaxStrelka = max;
        }
        public int Show()
        {
            int position = 3;
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position != MinStrelka)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow && position != MaxStrelka)
                {
                    position++;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }
    }
    class Programm
    {
        static string[] zakaz = new string[6];
        static int sum = 0;
        static void Forma()
        {
            if (zakaz[0] != null)
            {
                Console.Clear();
                Console.WriteLine("Вы уже выбрали форму");
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
            }
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите форму торта");
            Console.WriteLine("  Квадратный - 200");
            Console.WriteLine("  Круглый - 200");
            Console.WriteLine("  Сердечко - 300");
            MenuShow menu = new MenuShow(1, 3);
            int position = menu.Show();
            switch (position)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 200;
                    zakaz[0] = "квадратный - 200";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 200;
                    zakaz[0] = "круглый - 200";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 300;
                    zakaz[0] = "сердечко - 300";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;

            }
        }
        static void Razm()
        {
            if (zakaz[1] != null)
            {
                Console.Clear();
                Console.WriteLine("Вы уже выбрали размер");
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
            }
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите размер торта");
            Console.WriteLine("  Маленький - коржи 15 см - 200");
            Console.WriteLine("  Средний - коржи 25 см - 350");
            Console.WriteLine("  Большой - коржи 40 см - 500");
            MenuShow menu = new MenuShow(1, 3);
            int position = menu.Show();
            switch (position)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 200;
                    zakaz[1] = "маленький - коржи 15 см - 200";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 350;
                    zakaz[1] = "средний - коржи 25 см - 350";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 500;
                    zakaz[1] = "большой - коржи 40 см - 500";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;

            }
        }
        static void Vkus()
        {
            if (zakaz[2] != null)
            {
                Console.Clear();
                Console.WriteLine("Вы уже выбрали вкус");
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
            }
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите вкус коржей");
            Console.WriteLine("  Красный бархат - 300");
            Console.WriteLine("  Прага - 250");
            Console.WriteLine("  Три шоколада - 350");
            Console.WriteLine("  Птичье молоко - 200");
            MenuShow menu = new MenuShow(1, 4);
            int position = menu.Show();
            switch (position)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 300;
                    zakaz[2] = "красный бархат - 300";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 250;
                    zakaz[2] = "прага - 250";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 350;
                    zakaz[2] = "три шоколада - 350";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 200;
                    zakaz[2] = "Птичье молоко - 200";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        static void Kolvo()
        {
            if (zakaz[3] != null)
            {
                Console.Clear();
                Console.WriteLine("Вы уже выбрали количество");
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
            }
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите количество коржей");
            Console.WriteLine("  Один - 100");
            Console.WriteLine("  Два - 200");
            Console.WriteLine("  Три - 300");
            Console.WriteLine("  Четыре - 400");
            MenuShow menu = new MenuShow(1, 4);
            int position = menu.Show();
            switch (position)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 100;
                    zakaz[3] = "Один - 100";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 200;
                    zakaz[3] = "Два - 200";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 300;
                    zakaz[3] = "Три - 300";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 400;
                    zakaz[3] = "Четыре - 400";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        static void Glazur()
        {
            if (zakaz[4] != null)
            {
                Console.Clear();
                Console.WriteLine("Вы уже выбрали глазурь");
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
            }
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите глазурь");
            Console.WriteLine("  Шоколад - 150");
            Console.WriteLine("  Клубника - 200");
            Console.WriteLine("  Карамель - 300");
            MenuShow menu = new MenuShow(1, 3);
            int position = menu.Show();
            switch (position)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 150;
                    zakaz[4] = "Шоколад - 150";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 200;
                    zakaz[4] = "Клубника - 200";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 300;
                    zakaz[4] = "Карамель - 300";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        static void Decor()
        {
            if (zakaz[5] != null)
            {
                Console.Clear();
                Console.WriteLine("Вы уже выбрали декор");
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
            }
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите декор");
            Console.WriteLine("  Розочки из шоколада - 300");
            Console.WriteLine("  Розочки из мастики - 200");
            Console.WriteLine("  Карамельные цветы - 300");
            MenuShow menu = new MenuShow(1, 3);
            int position = menu.Show();
            switch (position)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 300;
                    zakaz[5] = "Розочки из шоколада - 300";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 200;
                    zakaz[5] = "Розочки из мастики - 200";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Добавлено в заказ");
                    sum += 300;
                    zakaz[5] = "Карамельные цветы - 300";
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        static void Konez()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Ваш заказ сохранен");
            DateTime data = DateTime.Now;
            string now = data.ToString();
            string path = "C:\\Users\\alexe\\source\\repos\\tortiki\\tortiki\\zakaz.txt";
            File.AppendAllText(path, "\nЗаказ от "+now);
            File.AppendAllText(path, "\nЗаказ: " + zakaz[0] + zakaz[1] + zakaz[2] + zakaz[3] + zakaz[4] + zakaz[5]);
            File.AppendAllText(path, "\nСумма " + sum);
        }
        static void Sbros()
        {
            sum = 0; zakaz[0]
        }
        static void Menu()
        {
            Console.WriteLine("Заказ тортов в Королевстве тортов, торты на выбор");
            Console.WriteLine("Выберите параметры торта");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("  Сброс заказа");
            Console.WriteLine("");
            foreach (var item in zakaz)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
            Console.WriteLine("Сумма " + sum);

            MenuShow menu = new MenuShow(3, 10);
            int position = menu.Show();
            switch (position)
            {
                case 3: Forma(); break;
                case 4: Razm(); break;
                case 5: Vkus(); break;
                case 6: Kolvo(); break;
                case 7: Glazur(); break;
                case 8: Decor(); break;
                case 9: Konez(); break;
            }
        }
        static void Main()
        {
            Menu();
        }
    }
}
namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Этап 1 Создание первичного массива для выборки
             */
            string[] array = GetUserArray();
            
            
        }

        

        private static string[] GetUserArray()
        {
            Console.WriteLine("Введите элементы первого массива через запятую. Для завершения ввода нажмите Enter");
            return Console.ReadLine().Split(',');
        }
    }
}
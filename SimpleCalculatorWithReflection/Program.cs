using System.Reflection;

namespace SimpleCalculatorWithReflection 
{
    class Program 
    {
        static void Main(string[] args)
        {
            ListOfComands();

            string comands = "";//Змінна в котрій буде зберігати команда у виді рядка.

            int firstNum; int secondNum;//Змінні в котрих буду зберігатися числа над якими
            //будуть проводитися матиматичні операції

            while (true)
            {
                //Присвоєння зміним з числами значень
                Console.Write("Введіть перше число: ");
                firstNum = int.Parse(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                secondNum = int.Parse(Console.ReadLine());

                //Присвоїння значення змінії з командою значення
                Console.Write("Ввеідть команду: ");
                comands = Console.ReadLine();

                //Перевірка на правильність команди
                if (comands == "+" || comands == "-" || comands == "*" || comands == "/")
                {
                    VerificationOfOperation(comands, firstNum, secondNum);
                }
                else
                {
                    Console.WriteLine("Не вірна команда.");
                }
            }
        }
        //Метод в котрому буде перевірятися котра імено команда була введена,
        //та вивід результату на консоль.
        static void VerificationOfOperation(string comand, int num1, int num2)
        {
            MethodInfo[] methods = typeof(Calculator).GetMethods();

            object[] attribytes;

            foreach (MethodInfo methodInfo in methods)
            {
                attribytes = methodInfo.GetCustomAttributes(true);

                foreach (Attribute attribute in attribytes)
                {
                    if (attribute is OperationAttribute operationAttribute)
                    {
                        if (operationAttribute.OperationName == comand)
                        {
                            methodInfo?.Invoke(null, new object[] { num1, num2 });
                        }
                    }
                }
            }
        }
        //Список команд
        static void ListOfComands()
        {
            Console.WriteLine("Список команд:");
            Console.WriteLine("+: додати два числа.");
            Console.WriteLine("-: відняти два числа.");
            Console.WriteLine("*: помножити два числа.");
            Console.WriteLine("/: поділити два числа.");
        }
    }
}

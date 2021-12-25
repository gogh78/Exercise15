using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
            //•	метод void setStart(int x) - устанавливает начальное значение
            //•	метод int getNext() -возвращает следующее число ряда
            //•	метод void reset() -выполняет сброс к начальному значению
            //Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
            //В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
            //int x;

            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Введите начальное значение прогрессии");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг прогрессии");
            int n = Convert.ToInt32(Console.ReadLine());

            arithProgression.setStart(x);
            arithProgression.Step(n);
            geomProgression.setStart(x);
            geomProgression.Step(n);

            Console.WriteLine("Арифметическая прогрессия числа {0} с шагом {1}", x, n);
            Console.WriteLine(x);
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();

            Console.WriteLine("Геометрическая прогрессия числа {0} с шагом {1}", x, n);
            Console.WriteLine(x);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int startValue;
        int currentValue;
        int step;
        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void Step(int n)
        {
            step = n;
        }
        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }
    }
    class GeomProgression : ISeries
    {
        int startValue;
        int currentValue;
        int step;
        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void Step(int n)
        {
            step = n;
        }
        public int getNext()
        {
            currentValue = currentValue * step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }
    }
}

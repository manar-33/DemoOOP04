using DemoOOP04.Icloneable_Interface;
using DemoOOP04.Interface;
using System.Text;

namespace DemoOOP04
{
    internal class Program
    {
        public static void SeriesByTwo(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
        }
            static void Main(string[] args)
            {
            #region Interface
            //IMyType myType = new MyType();
            //myType.Id = 100;
            //myType.Myfun(200);
            //myType.Print(); 
            #endregion
            #region Interface EX
            //Series series = new Series();
            //SeriesByTwo(series);
            #endregion
            #region Array Of Value Type
            #region Shallow Copy [Stack]

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];
            //Console.WriteLine($"HC01 Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC01 Arr02: {Arr02.GetHashCode()}");
            //Arr01 = Arr02;
            //Console.WriteLine("====================== After Shallow Copy");
            //Console.WriteLine($"HC01 Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC01 Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine($"Arr01: {Arr01[0]}");
            //Console.WriteLine($"Arr01: {Arr02[0]}");
            //Arr01[0] = 100;
            //Console.WriteLine("After Arr01[0] = 100;");
            //Console.WriteLine($"Arr01: {Arr01[0]}");
            //Console.WriteLine($"Arr01: {Arr02[0]}");

            #endregion
            #region Deep Copy [Heap]
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];
            //Console.WriteLine($"HC01 Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC01 Arr02: {Arr02.GetHashCode()}");
            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine("============");
            //Console.WriteLine($"HC01 Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC01 Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine("=================");
            //Console.WriteLine($"Arr01: {Arr01[0]}");
            //Console.WriteLine($"Arr02: {Arr02[0]}");
            //Arr01[0] = 100;
            //Console.WriteLine("after change");
            //Console.WriteLine($"Arr01: {Arr01[0]}");
            //Console.WriteLine($"Arr02: {Arr02[0]}");
            #endregion

            #endregion
            #region Array Of Reference Type
            #region Shallow Copy
            //string[] Names01 = { "Manar" };
            //string[] Names02 = new string[1];
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Names02 = Names01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}");
            //Names02[0] = "aya";
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}"); 
            #endregion
            #region Deep Copy
            //string[] Names01 = { "Manar" };
            //string[] Names02 = new string[1];
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Names02 = (string[])Names01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}");
            //Names02[0] = "Diana";
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}");
            #endregion

            #endregion
            #region Array Of Reference Type String Builder
            #region Shallow Copy
            //StringBuilder[] Names01=new StringBuilder[1];
            //Names01[0] = new StringBuilder("Manar");
            //StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Names02 = Names01;
            //Console.WriteLine("after shallow copy");
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}");
            //Names02[0].Append(" Mahmoud");
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}");

            #endregion
            #region Deep Copy
            //StringBuilder[] Names01=new StringBuilder[1];
            //Names01[0] = new StringBuilder("Manar");
            //StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Names02 = (StringBuilder[]) Names01.Clone();
            //Console.WriteLine("After deep copy");
            //Console.WriteLine($"HC of Names01 : {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 : {Names02.GetHashCode()}");
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}");
            //Names02[0].Append(" Mahmoud");
            //Console.WriteLine($"Names01: {Names01[0]}");
            //Console.WriteLine($"Names02: {Names02[0]}");

            #endregion
            #endregion
            #region ICloneable
            //Employee employee01 = new Employee() { Id=10, Name ="Manar", Salary=5000};
            //Employee employee02 = new Employee() { Id = 20, Name = "Diana", Salary = 6000 };
            //Console.WriteLine($"HC of Employee01: {employee01.GetHashCode()}");
            //Console.WriteLine(employee01);
            //Console.WriteLine($"HC of Employee02: {employee02.GetHashCode()}");
            //Console.WriteLine(employee02);
            #region Shallow Copy
            //Console.WriteLine("After Shallow Copy");
            //employee02 = employee01;
            //Console.WriteLine($"HC of Employee01: {employee01.GetHashCode()}");
            //Console.WriteLine(employee01);
            //Console.WriteLine($"HC of Employee02: {employee02.GetHashCode()}");
            //Console.WriteLine(employee02);
            //employee01.Id = 60;
            //employee01.Name = "amr";
            //employee01.Salary = 6565;
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);
            #endregion
            #region Deep Copy
            //Console.WriteLine(" After Deep Copy");
            //employee02 = (Employee)employee01.Clone();
            //Console.WriteLine($"HC of Employee01: {employee01.GetHashCode()}");
            //Console.WriteLine(employee01);
            //Console.WriteLine($"HC of Employee02: {employee02.GetHashCode()}");
            //Console.WriteLine(employee02);
            #endregion
            #endregion
            #region ICompareable
            //Employee[] employees = new Employee[4]
            //{
            //new Employee() {Id = 1 , Name ="Manar", Salary=5000 },
            //new Employee() {Id = 2 , Name ="Mona", Salary=4000 },
            //new Employee() {Id = 3 , Name ="Naya", Salary=7000 },
            //new Employee() {Id = 4 , Name ="Maya", Salary=9000 }
            //};
            //Array.Sort(employees);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

        }
    }
    }


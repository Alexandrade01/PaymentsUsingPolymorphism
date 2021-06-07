using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExPayPolimorfism.Entities;
using System.Globalization;

namespace ExPayPolimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Payments = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int.TryParse(Console.ReadLine(), out int qtd);
            for (int i = 1; i <= qtd; i++)
            {
                do
                {
                    try
                    {
                        Console.WriteLine($"Employee #{i} data:");
                        Console.Write("Outsourced (y/n)?");
                        string resp = Console.ReadLine();
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Value per hour: ");
                        double valuephour = Convert.ToDouble(Console.ReadLine());
                        if (resp.ToUpper() == "N")
                        {
                            Payments.Add(new Employee(name, hours, valuephour));
                            break;
                        }
                        else if (resp.ToUpper() == "Y")
                        {
                            Console.WriteLine("Additional charge: ");
                            double additional = Convert.ToDouble(Console.ReadLine());
                            Payments.Add(new OutSourcedEmployee(name, hours, valuephour, additional));
                            break;
                        }
                       
                            throw new Exception("Dados Invalidos");
                    }
                   
                  
                    catch 
                    {
                        Console.WriteLine("Dados Invalidos! ");
                    }

                }
                while (true);
               

               

            }
            foreach (var payment in Payments)
            {
                Console.WriteLine($"{payment.Name} - {payment.Payment().ToString("C2",CultureInfo.CurrentCulture)}");
            }

        }
    }
}




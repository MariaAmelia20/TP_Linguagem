 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa
{
    class Empregado
    {
        
        private string primeiroNome;
        private string sobrenome;
        private double salarioMensal;


        public Empregado(string nome, string sobrenome, double salario)
        {
            this.primeiroNome = nome;
            this.sobrenome = sobrenome;

            if (salario > 0)
                this.salarioMensal = salario;
            else
                this.salarioMensal = 0;



                    }
                    

                    public string GetNome()
                    {
                        return primeiroNome;
                    }
                    public void SetNome(string nome)
                    {
                        primeiroNome = nome;
                    }
                    public string GetSobrenome()
                    {
                        return sobrenome;
                    }
                    public void SetSobrenome(string sobrenome)
                    {
                        this.sobrenome = sobrenome;
                    }
                    public double GetSalarioMensal()
                    {
                        return salarioMensal;
                    }
                    public void SetSalarioMensal(double salario)
                    {
                        if (salario > 0)
                            salarioMensal = salario;
                    }

             
                    public double SalarioAnual()
                    {
                        return salarioMensal * 12;
                    }
                }



    class Program
    {
        static void Main(string[] args)
        {
           
            Empregado emp1 = new Empregado("Maria", "Amelia", 8000);
            Empregado emp2 = new Empregado("João", "Martins", 12000);


       
            Console.WriteLine("Salário anual inicial:");
            Console.WriteLine(emp1.GetNome() + " " + emp1.GetSobrenome() + ": " + emp1.SalarioAnual());
            Console.WriteLine(emp2.GetNome() + " " + emp2.GetSobrenome() + ": " + emp2.SalarioAnual());
        
            emp1.SetSalarioMensal(emp1.GetSalarioMensal() * 0.15);
            emp2.SetSalarioMensal(emp2.GetSalarioMensal() * 0.15);


            Console.WriteLine("\nApós ao Acrescimento de 15%:");
            Console.WriteLine(emp1.GetNome() + ": " + emp1.SalarioAnual());
            Console.WriteLine(emp2.GetNome() + ": " + emp2.SalarioAnual());
            Console.ReadLine();


        }
    }
}
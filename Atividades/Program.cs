using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                double salarioAnual, prestacaoServico, capital, gastosMedicos, gastosEducacionais, impostoServico, impostoCapital, impostoSalario;
               
                impostoSalario = 0;

                Console.Write("Renda anual com salario: ");
                salarioAnual = double.Parse(Console.ReadLine(), CI);
               Console.Write("Reda anual com prestação de serviços: ");
                prestacaoServico = double.Parse(Console.ReadLine(), CI);
               Console.Write("Reda anual com ganho de capital: ");
                capital = double.Parse(Console.ReadLine(), CI);
                Console.Write("Gasto medicos: ");
                gastosMedicos = double.Parse(Console.ReadLine(), CI);
                Console.Write("Gastow educacionais: ");
                gastosEducacionais = double.Parse(Console.ReadLine(), CI);

                //*********************************************************************
                double salarioMensal = salarioAnual / 12;

                if (salarioMensal < 3000.0)
                {
                    impostoSalario = salarioMensal * 0.0;
                }
                else if (salarioMensal >= 3000 && salarioMensal < 5000)
                {
                    impostoSalario = (salarioMensal * 0.10) * 12 ;
                }
                else
                {
                    impostoSalario = (salarioMensal * 0.20) * 12;
                }
                //*********************************************************************

                impostoServico = prestacaoServico * 0.15;

                impostoCapital = capital * 0.20;

                double maxDedutivel = salarioAnual * 0.30;

                double gastosDeduciveis = gastosMedicos + gastosEducacionais;
                double deducoes = Math.Min(gastosDeduciveis, maxDedutivel);
                

                double impostoBrutoTotal = impostoSalario + impostoServico + impostoCapital;

       
                double impostoDevido = impostoBrutoTotal - deducoes;


                Console.WriteLine("RELATORIO DE IMPOSTO DE RENDA: ");

                Console.WriteLine();
                //*********************************************************************
                Console.WriteLine("CONSOLIDADO DE RENDA: "); 
               Console.WriteLine("Imposto sobre salario: " + impostoSalario.ToString("F2", CI));
                 Console.WriteLine("Imposto sobre serviço: "+ impostoServico.ToString("F2", CI));
                Console.WriteLine("Imposto sobre ganho de capital: " + impostoCapital.ToString("F2", CI));

                Console.WriteLine();

                Console.WriteLine("DEDUÇÕES: ");
                Console.WriteLine("Maximo dedutivel: " + maxDedutivel.ToString("F2", CI));
                Console.WriteLine("Gastos dedutiveis: " + gastosDeduciveis.ToString("F2", CI));
                Console.WriteLine();

                Console.WriteLine("RESUMO: "); 
                Console.WriteLine("Imposto bruto total: " + impostoBrutoTotal.ToString("F2", CI));
                Console.WriteLine("Abastimento: " + deducoes.ToString("F2", CI));
                Console.WriteLine("Imposto devido: " + impostoDevido.ToString("F2", CI));


            }
        }
    }
}


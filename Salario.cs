//Cauê Saad
using System;
class Salario
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do funcionário");
        string Nome_f = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de horas trabalhadas");
        int horas_trab = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite quanto você recebe por hora");
        double tax_pag = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o quanto você ganhou com as comições dessa semana");
        decimal comissoes_sem = Convert.ToInt32(Console.ReadLine());
        decimal salario_brute = (decimal)(horas_trab * tax_pag) + comissoes_sem; 
        
        Console.WriteLine($"O nome do funcionário é {Nome_f}");
        Console.WriteLine($"O solário do funcionário é {salario_brute}");  
    }
}

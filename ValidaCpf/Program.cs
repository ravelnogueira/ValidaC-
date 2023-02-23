using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o CPF a ser validado: ");
        string cpf = Console.ReadLine();

        if (ValidaCPF(cpf))
        {
            Console.WriteLine("CPF válido!");
        }
        else
        {
            Console.WriteLine("CPF inválido!");
        }
    }

    static bool ValidaCPF(string cpf)
    {
        CPFValidator cpfValidator = new CPFValidator();
        return cpfValidator.ValidaCPF(cpf);
    }
}
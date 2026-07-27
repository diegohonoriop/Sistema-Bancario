using System;

class Program
{
    static void Main()
    {
        // Cabeçalho do sistema
        Console.WriteLine("==========================");
        Console.WriteLine("      BANCO DO DIEGO      ");
        Console.WriteLine("==========================");
        Console.WriteLine();

        // Entrada de dados do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Saldo atual: R$ ");
        double saldo = double.Parse(Console.ReadLine());

        // CORREÇÃO AQUI (Linha 18 do seu código): Mudado de WriteLine para Write 
        // para o usuário digitar o valor na mesma linha do "R$"
        Console.Write("Quanto deseja sacar? R$ ");
        double saque = double.Parse(Console.ReadLine());

        Console.WriteLine(); 

        // Verificação do saldo para o saque
        if (saque > saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            double novoSaldo = saldo - saque;
            
            // CORREÇÃO AQUI (Linhas 31 e 33 do seu código):
            // 1. O '$' foi colocado ANTES das aspas ($"...)
            // 2. A variável foi corrigida para 'novoSaldo' (sem o 's' intrometido)
            // 3. Juntamos a mensagem para ficar organizada e sem repetições
            Console.WriteLine("Saque realizado com sucesso.");
            Console.WriteLine($"Novo saldo: R$ {novoSaldo:F2}");
        }
    }
}
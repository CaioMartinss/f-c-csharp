// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System;


int a = 2;
int b = 1;
var c = 1;

if (a > b && a > c)
{
    Console.WriteLine("O número " + a + " é maior");
}
if (b > a && b > c)
{
    Console.WriteLine("O número " + b + " é maior");
}
if (c > a && c > b)
{
    Console.WriteLine("O número " + c + " é maior");
}


static void method()
{
    Console.WriteLine("my method");
}

method();

static string Nome(string nome)
{
    const string nNome = "Insira um nome válido";
    if (string.IsNullOrEmpty(nome))
    {
        Console.WriteLine("INSIRA UM NOME VÁLIDO");
        return nNome;
    }
    else
    {
        Console.WriteLine("Nome: " + nome);
        return nome; // Retorna o próprio nome, não a mensagem de erro
    }
}


Nome("Calabreso");
Nome("Anitto");
Nome("hdhd");




public class Banco
{
    protected int saldo = 0;
    public string? nome_titular;
    private readonly int cpf;
    public bool conta_ativa;

    public Banco(int saldo, string? nome_titular, int cpf, bool conta_ativa)
    {
        this.saldo = saldo;
        this.nome_titular = nome_titular;
        this.cpf = cpf;
        this.conta_ativa = conta_ativa = true;
    }

    private void verifica_nome_titular()
    {
        if (conta_ativa)
        {
            string pattern = "^[a-zA-Z]+$";
            if (!Regex.IsMatch(nome_titular, pattern))
            {
                Console.WriteLine("Nome inválido");
            }
            else
            {
                Console.WriteLine("");
                nome_titular = pattern;
            }


        }
    }

    void sacar(int valor)
    {
        if (this.conta_ativa)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Impossível sacar, o valor desejado é maior do que o saldo!");
            }
            else
            {
                this.saldo -= valor;
                Console.WriteLine("Saque de " + valor + " realizado com sucesso. Novo saldo: " + this.saldo);
            }
        }
        else
        {
            Console.WriteLine("A conta não está ativa. Não é possível realizar saques.");
        }
    }



    void depositar(int valor) 
    {
        if (this.conta_ativa)
        {
            this.saldo += valor;
        }   
    }


}





class conta_conrrente : Banco
{
    public conta_conrrente(int saldo, string? nome_titular, int cpf, bool conta_ativa) : base(saldo, nome_titular, cpf, conta_ativa)
    {
        this.conta_ativa = conta_ativa;
        this.saldo = saldo;
        this.nome_titular= nome_titular;
    }




}


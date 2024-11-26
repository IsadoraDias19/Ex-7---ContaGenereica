
using Ex_7___ContaGenereica;

ContaCorrente1 cont1 = new ContaCorrente1
{
    Banco = "Santander",
    Agencia = 033,
    Conta = "Marina da Silva",
    Saldo = 4000,
};
ContaCorrente2 cont2 = new ContaCorrente2
{
    Banco = "Bradesco",
    Agencia = 237,
    Conta = "Cauã Leite Ferreira",
    Saldo = 2000,
};
ContaCorrente3 cont3 = new ContaCorrente3
{
    Banco = "Nubank",
    Agencia = 0001,
    Conta = "Isadora Dias Cordeiro de Souza",
    Saldo = 6000,
};

Console.WriteLine($"\nBanco:{cont1.Banco}, Agencia: {cont1.Agencia},a sua conta é {cont1.Conta},seu Saldo: {cont1.Saldo}");
Console.WriteLine($"\nBanco:{cont2.Banco}, Agencia: {cont2.Agencia},a sua conta é {cont2.Conta},seu Saldo: {cont2.Saldo}");
Console.WriteLine($"\nBanco:{cont3.Banco}, Agencia: {cont3.Agencia},a sua conta é {cont3.Conta},seu Saldo: {cont3.Saldo}");


cont1.Depositar();
cont1.Sacar();
cont2.Depositar();
cont2.Sacar();
cont3.Depositar();
cont3.Sacar();  

Console.ReadKey();
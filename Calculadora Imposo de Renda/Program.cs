using Calculadora_Imposo_de_Renda.uteis;

Console.WriteLine("Sejam Bem vindos ao seu adiantador de tempo na hora de pagar seus impostos, mesmo que seja roubo.");
Console.WriteLine("0 - Sair\n1 - Fazer Imposto de Renda\n2 - Torres de Hanoi: ");
int opt;
do
{
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case 0:
            opt = 0;
            break;

        case 1:
            break;

        case 2:
            TorresHanoi.TorresHanoiGame();
            break;

        case 3:
            break;

    }
} while (opt != 0);

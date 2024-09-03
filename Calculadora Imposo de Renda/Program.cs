using Calculadora_do_Leão_da_Federal.classes;

Console.WriteLine("Sejam Bem vindos ao seu adiantador de tempo na hora de pagar seus impostos, mesmo que seja roubo.");
Console.WriteLine("0 - Sair\n1 - Soma\n2 - Conversor\n3 - Fazer Imposto de Renda\nO que deseja fazer?: ");
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
            Receber();
            var res = calculadora.Soma(num1, num2);
            break;

        case 2:
            break;

        case 3:
            break;

    }
} while (opt != 0);

void Receber()
{
    Console.Write("Digite o primeiro numero: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());
}
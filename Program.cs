List<string> historico = new List<string>();
string continuar = "s";

while (continuar == "s")
{
    double numero1 = LerNumero("Digite o primeiro número:");
    double numero2 = LerNumero("Digite o segundo número:");

    Console.WriteLine("Escolha a operação (+, -, *, /, ^ para potência, r para raiz do primeiro número):");
    string? operacao = Console.ReadLine();

    double resultado = 0;
    bool operacaoValida = true;

    switch (operacao)
    {
        case "+":
            resultado = Somar(numero1, numero2);
            break;

        case "-":
            resultado = Subtrair(numero1, numero2);
            break;

        case "*":
            resultado = Multiplicar(numero1, numero2);
            break;

        case "/":
            if (numero2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                operacaoValida = false;
            }
            else
            {
                resultado = Dividir(numero1, numero2);
            }
            break;

        case "^":
            resultado = Math.Pow(numero1, numero2);
            break;

        case "r":
            if (numero1 < 0)
            {
                Console.WriteLine("Não existe raiz quadrada de número negativo.");
                operacaoValida = false;
            }
            else
            {
                resultado = Math.Sqrt(numero1);
            }
            break;

        default:
            Console.WriteLine("Operação inválida.");
            operacaoValida = false;
            break;
    }

    if (operacaoValida)
    {
        Console.WriteLine($"Resultado: {resultado}");
        historico.Add($"{numero1} {operacao} {numero2} = {resultado}");
    }

    Console.WriteLine("Deseja fazer outra conta? (s/n)");
    continuar = Console.ReadLine()?.ToLower() ?? "n";
}

Console.WriteLine();
Console.WriteLine("Histórico de contas:");

if (historico.Count == 0)
{
    Console.WriteLine("Nenhuma conta realizada.");
}
else
{
    foreach (string item in historico)
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine("Até logo!");

static double LerNumero(string mensagem)
{
    while (true)
    {
        Console.WriteLine(mensagem);

        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            return numero;
        }

        Console.WriteLine("Valor inválido. Digite apenas números.");
    }
}

static double Somar(double a, double b)
{
    return a + b;
}

static double Subtrair(double a, double b)
{
    return a - b;
}

static double Multiplicar(double a, double b)
{
    return a * b;
}

static double Dividir(double a, double b)
{
    return a / b;
}
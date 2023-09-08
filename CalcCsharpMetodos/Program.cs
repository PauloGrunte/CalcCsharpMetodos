
int IsNumber(string value, string console)
{
    int outInt;
    bool BoolIsNumber = int.TryParse(value, out outInt);
    while (BoolIsNumber == false)
    {
        Console.WriteLine(console);
        value = Console.ReadLine();
        BoolIsNumber = int.TryParse(value, out outInt);
    }
    return outInt;
}
string LerValor(string value)
{
    Console.WriteLine(value);
    string inpt = Console.ReadLine();
    return inpt;
}

string LerOperador(string value)
{
    Console.WriteLine(value);
    string inpt = Console.ReadLine();
    while (inpt != "+" && inpt != "-" && inpt != "*" && inpt != "/")
    {
        Console.WriteLine("Operador inválido, digite novamente");
        inpt = Console.ReadLine();
    }
    return inpt;
}
int Somar(int Num1, int Num2)
{
    int soma = Num1 + Num2;
    return soma;
}
int Multiplicar(int Num1, int Num2)
{
    int multiplicacao = Num1 * Num2;
    return multiplicacao;
}
int Subtrair(int Num1, int Num2)
{
    int subtacao = Num1 - Num2;
    return subtacao;
}
int Dividir(int Num1, int Num2)
{
    int divisao = Num1 / Num2;
    return divisao;
}
string inpt = LerValor("Digite o primeiro valor");
int valor1 = IsNumber(inpt, "Valor do primeiro numero é iválido, digite novamente");
string inpt2 = LerValor("Digite o segundo valor");
int valor2 = IsNumber(inpt2, "Valor do segundo numero é inválido, digite novamente");
string operador = LerOperador("Digite o operador (+, -, /, *)");
switch (operador)
{
    case "+":
        Console.WriteLine(Somar(valor1, valor2)); break;
    case "-":
        Console.WriteLine(Subtrair(valor1, valor2)); break;
    case "*":
        Console.WriteLine(Multiplicar(valor1, valor2)); break;
    case "/":
        Console.WriteLine(Dividir(valor1, valor2)); break;
    default:
        Console.WriteLine("ERRO");
        break;
}
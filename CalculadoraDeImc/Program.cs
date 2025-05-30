using CalculadoraDeImc;
List<Pessoa> listaPessoa = new List<Pessoa>();
Console.WriteLine("Você quer consultar o IMC de uma ou várias pessoas (uma / varias )");
string resposta  = Console.ReadLine();

if (resposta.ToLower() == "varias")
{
    Console.WriteLine("Quantas pessoas você quer analisar ?");
    int n1 = int.Parse(Console.ReadLine());
    for(int i = 0; i < n1; i++)
    {
        Console.WriteLine("Digite o nome da " + i + " pessoa");
        string name = Console.ReadLine();
        Console.WriteLine("Insira a idade da " + i + " pessoa");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o peso da " + i + " pessoa");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a altura da" + i + " pessoa");
        double height = double.Parse(Console.ReadLine());
        Pessoa pessoa = new Pessoa(name,age,weight,height);
        listaPessoa.Add(pessoa);

    }
}
else
{
    Console.WriteLine("Digite o nome da pessoa");
    string name = Console.ReadLine();
    Console.WriteLine("Insira a idade da  pessoa");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o peso da pessoa");
    double weight = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira a altura da pessoa");
    double height = double.Parse(Console.ReadLine());
    Pessoa pessoa = new Pessoa(name, age, weight, height);
    listaPessoa.Add(pessoa);
}
foreach (var pe in listaPessoa)
{
    double imc = pe.IMC();
    string classificacao = pe.IMCtxt();

    Console.WriteLine("Nome: " + pe.name);
    Console.WriteLine("Idade: " + pe.age);
    Console.WriteLine("Peso: " + pe.weight);
    Console.WriteLine("Altura: "+ pe.height);
    Console.WriteLine("IMC: " + pe.IMC());
    Console.WriteLine("Classificação: " + pe.IMCtxt());
}
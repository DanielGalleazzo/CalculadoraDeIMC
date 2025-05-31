import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Pessoa> pessoaList = new ArrayList<>();
        System.out.println("Você quer consultar o IMC de uma ou várias pessoas (uma / varias )");
        String resposta = sc.next();
        if (resposta == "varias")
        {
            System.out.println("Quantas pessoas você quer analisar ?");
            int n1 = sc.nextInt();
            for(int i = 0; i < n1; i++)
            {
                System.out.println("Digite o nome da " + i + " pessoa");
                String name = sc.next();
                System.out.println("Insira a idade da " + i + " pessoa");
                int age = sc.nextInt();
                System.out.println("Insira o peso da " + i + " pessoa");
                double weight = sc.nextDouble();
                System.out.println("Insira a altura da" + i + " pessoa");
                double height = sc.nextDouble();
                Pessoa pessoa = new Pessoa(name,age,weight,height);
                pessoaList.add(pessoa);
            }
        }
        else
        {
            System.out.println("Digite o nome da pessoa");
            String name = sc.next();
            System.out.println("Insira a idade da  pessoa");
            int age = sc.nextInt();
            System.out.println("Insira o peso da pessoa");
            double weight = sc.nextDouble();
            System.out.println("Insira a altura da pessoa");
            double height = sc.nextDouble();
            Pessoa pessoa = new Pessoa(name, age, weight, height);
            pessoaList.add(pessoa);
        }
        for (Pessoa pe : pessoaList) {
            double imc = pe.IMC();
            String classificacao = pe.IMCtxt();

            System.out.println("Nome: " + pe.getName());
            System.out.println("Idade: " + pe.getAge());
            System.out.println("Peso: " + pe.getWeight());
            System.out.println("Altura: " + pe.getHeight());
            System.out.println("IMC: " + imc);
            System.out.println("Classificação: " + classificacao);
        }

    }
}
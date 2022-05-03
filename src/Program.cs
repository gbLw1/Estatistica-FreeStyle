using static System.Console;

public class Program
{
    public static void Main(string[] args)
    {
        Write("Infome a % de sucesso em decimal: ");
        double s = double.Parse(ReadLine());

        Write("Infome a % de falha em decimal: ");
        double f = double.Parse(ReadLine());

        Write("Infome a quantidade da amostra: ");
        double n = double.Parse(ReadLine());

        int retry = 1;
        do
        {
            Write("Informe o número de possibilidades (x=?): ");
            double r = double.Parse(ReadLine());

            Func<double, double> fat = null;
            fat = x => x <= 1 ? 1 : x * fat(x - 1);

            double c = fat(n) / (fat(r) * fat(n - r));
            WriteLine($"C({n},{r}) = {c}");

            double ProbTotalDecimal = c * Math.Pow(s, r) * Math.Pow(f, (n-r));
            double ProbTotalPorcentagem = ProbTotalDecimal * 100;
            WriteLine($"P(x={r}) : {ProbTotalDecimal.ToString("n4")} -> {ProbTotalPorcentagem:n2}%");


            Write("Digite {1} para realizar outra operação: ");
            retry = int.Parse(ReadLine());
        } while (retry == 1);
    }
}

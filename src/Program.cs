public class Program
{
    public static void Main(string[] args)
    {
        // Console.Write("Informe o valor total de elementos: ");
        // double n = double.Parse(Console.ReadLine());

        // Console.Write("Informe o número de combinações possíveis: ");
        // double r = double.Parse(Console.ReadLine());

        // Func<double, double> fat = null;
        // fat = x => x <= 1 ? 1 : x * fat(x - 1);

        // var c = fat(n) / (fat(r) * fat(n - r));

        // Console.WriteLine($"C({n},{r}) = {c}");



        // var total = c * Math.Pow(0.10, 2) * Math.Pow(0.90, 13);

        // Console.WriteLine($"C(15,2) = {c} \nTotal = {total}");

        Console.Write("Infome a % de sucesso em decimal: ");
        double s = double.Parse(Console.ReadLine());

        Console.Write("Infome a % de falha em decimal: ");
        double f = double.Parse(Console.ReadLine());

        Console.Write("Infome a quantidade da amostra: ");
        double n = double.Parse(Console.ReadLine());

        int resp = 1;
        do
        {
            Console.Write("Informe o número de possibilidades (x=?): ");
            double r = double.Parse(Console.ReadLine());

            Func<double, double> fat = null;
            fat = x => x <= 1 ? 1 : x * fat(x - 1);

            double c = fat(n) / (fat(r) * fat(n - r));

            Console.WriteLine($"C({n},{r}) = {c}");

            double ProbTotalDecimal = c * Math.Pow(s, r) * Math.Pow(f, (n-r));
            double ProbTotalPorcentagem = ProbTotalDecimal * 100;
            Console.WriteLine($"P(x={r}) : {ProbTotalDecimal.ToString("n4")} -> {ProbTotalPorcentagem:n2}%");


            Console.Write("Digite {1} para realizar outra operação: ");
            resp = int.Parse(Console.ReadLine());
        } while (resp == 1);
    }
}

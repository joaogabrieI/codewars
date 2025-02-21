class Program
{
    public static void Main(string[] args)
    {
        // int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15];
        // foreach (var num in CountPositivesSumNegatives(numeros))
        // {
        //     Console.WriteLine(num);
        // }
        // Console.WriteLine(Greet("João"));

        double[] amostras = new double[5];
        amostras.SetValue(8.3, 0);
        amostras.SetValue(7.0, 1);
        amostras.SetValue(3.4, 2);
        amostras.SetValue(5.2, 3);
        amostras.SetValue(9.7, 4);

        Media(amostras);

        // System.Console.WriteLine(dnaToRna("GCAT"));
        System.Console.WriteLine(NameShuffler("john McClane"));
    }

    public static string Greet(string name)
    {
        return $"Hello, {name} how are you doing today?";
    }

    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int[] output = [];
        int negatives = 0;
        int positives = 0;
        if (input != null)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    positives += 1;
                }

                if (input[i] < 0)
                {
                    negatives += input[i];
                }
                output = [positives, negatives];
            }
        }
        return output;
    }

    static void Media(double[] amostras)
    {
        double soma = 0;
        for (int i = 0; i < amostras.Length; i++)
        {
            soma += Convert.ToDouble(amostras.GetValue(i));
        }
        Console.WriteLine($"Média: {(soma / amostras.Length):N2}");
    }

    public static string NameShuffler(string str)
    {
        int divisor = 0;
        string primeiraParte = "";
        string segundaParte = "";
        for(int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                divisor = i;
            }
        }

        for(int j = 0; j < divisor; j++)
        {
            primeiraParte += str[j];
        }

        for(int k = divisor+1; k < str.Length; k++)
        {
            segundaParte += str[k];
        }    

        return segundaParte + " " + primeiraParte;
    }

    public static string dnaToRna(string dna)
    {
        // StringBuilder rna = new StringBuilder(dna);
        string result = "";
        if (dna != null)
        {
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i].Equals('T'))
                {
                    // rna[i] = 'U';
                    result += 'U';
                }
                else
                {
                    result += dna[i];
                }
            }
        }
        //  return rna.ToString();
        return result;
    }
}
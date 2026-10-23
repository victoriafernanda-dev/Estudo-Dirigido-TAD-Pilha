public class BubblePilhas
{
    public static void Executar()
    {
        int[] vetor = {1, 2, 5, 7, 9 };

        int[] ordenado = bubblePilhas(vetor, out int comparacoes);

        Console.WriteLine("Vetor ordenado:");

        foreach (int numero in ordenado)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Comparações: " + comparacoes);
    }

    public static int[] bubblePilhas(int[] v, out int comparacoes)
    {
        Pilha A = new Pilha(v.Length);
        Pilha B = new Pilha(v.Length);
        Pilha R = new Pilha(v.Length);

        comparacoes = 0;

        foreach (int numero in v)
        {
            A.empilha(numero);
        }

        for (int restantes = v.Length; restantes >= 1; restantes--)
        {
            int carry = A.desempilha();

            for (int i = 1; i < restantes; i++)
            {
                int x = A.desempilha();
                comparacoes++;

                if (carry > x)
                {
                    B.empilha(x);
                }
                else
                {
                    B.empilha(carry);
                    carry = x;
                }
            }

            R.empilha(carry);

            Console.WriteLine("Carry final: " + carry);

            Console.Write("B: ");
            B.mostra();

            Console.Write("R: ");
            R.mostra();

            Console.WriteLine("----------");

            // Troca os papéis das pilhas A e B
            Pilha auxiliar = A;
            A = B;
            B = auxiliar;
        }

        int[] resultado = new int[v.Length];

        for (int i = 0; i < resultado.Length; i++)
        {
            resultado[i] = R.desempilha();
        }

        return resultado;
    }
}

public class Pilha
{
    private int[] item;
    private int topo;

    public Pilha(int maxTam)
    {
        item = new int[maxTam];
        topo = 0;
    }

    public bool vazia()
    {
        return topo == 0;
    }

    public bool cheia()
    {
        return topo == item.Length;
    }

    public int tamanho()
    {
        return topo;
    }

    public void empilha(int x)
    {
        if (cheia())
        {
            throw new Exception("Erro: pilha cheia");
        }

        item[topo] = x;
        topo++;
    }

    public int desempilha()
    {
        if (vazia())
        {
            throw new Exception("Erro: pilha vazia");
        }

        topo--;
        return item[topo];
    }

    public int consultaTopo()
    {
        if (vazia())
        {
            throw new Exception("Erro: pilha vazia");
        }

        return item[topo - 1];
    }

    public void mostra()
    {
        Console.Write("[");

        for (int i = 0; i < topo; i++)
        {
            Console.Write(item[i]);

            if (i < topo - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("]");
    }

    public static void Executar()
    {
        Pilha p = new Pilha(5);

        p.empilha(1); 
        p.empilha(3); 
        p.empilha(5); 
        p.empilha(7);
        p.mostra(); // [1, 3, 5, 7]

        Console.WriteLine(p.desempilha()); // 7
        Console.WriteLine(p.consultaTopo()); // 5

        p.empilha(8); 
        p.empilha(9);
        p.mostra(); // [1, 3, 5, 8, 9]

        Console.WriteLine(p.cheia()); // True

        try
        { 
            p.empilha(2); 
        }
        catch (Exception e) 
        { 
            Console.WriteLine(e.Message);
        } // Erro: pilha cheia
    }
}


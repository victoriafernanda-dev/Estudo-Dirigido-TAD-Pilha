public class Inverte
{
    public static void Executar()
    {
        Console.WriteLine(inverte("PUCMINAS"));
    }

    static string inverte(string s)
    {
        Pilha p = new Pilha(s.Length);

        foreach (char c in s)
        {
            p.empilha(c);
        }

        string resultado = "";

        while (!p.vazia())
        {
            resultado += (char)p.desempilha();
        }

        return resultado;
    }
}
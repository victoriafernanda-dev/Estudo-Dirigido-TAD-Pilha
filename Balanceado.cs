public class Balanceado
{
    public static void Executar()
    {
        Console.WriteLine(balanceado("(a+b)*[c-d]"));
        Console.WriteLine(balanceado("{[()]}"));
        Console.WriteLine(balanceado("((a)"));
        Console.WriteLine(balanceado("a+b)"));
        Console.WriteLine(balanceado("([)]"));
    }


    static bool balanceado(string expr)
    {
        Pilha p = new Pilha(expr.Length);

        foreach (char c in expr)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                p.empilha(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (p.vazia())
                    return false;

                char abertura = (char)p.desempilha();

                if (c == ')' && abertura != '(')
                    return false;

                if (c == ']' && abertura != '[')
                    return false;

                if (c == '}' && abertura != '{')
                    return false;
            }
        }

        return p.vazia();
    }

}
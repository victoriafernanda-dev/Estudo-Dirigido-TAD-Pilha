
public class OrdenarPilha
{
    public static void Executar()
    {
        Pilha p = new Pilha(5);

        p.empilha(3);
        p.empilha(1);
        p.empilha(8);
        p.empilha(6);

        Pilha ordenada = ordenaPilha(p);

        ordenada.mostra();
    }
    public static Pilha ordenaPilha(Pilha p)
    {
        Pilha aux = new Pilha(100);
        int t;

        while (!p.vazia())
        {
            t = p.desempilha();

            while (!aux.vazia() && aux.consultaTopo() > t)
            {
                p.empilha(aux.desempilha());
            }

            aux.empilha(t);
        }

        return aux;
    }
}

public class C2
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Sumar(int a, int b)
    {
        return a + b;
    }
    //Se agrega este comentario despues del stash
    public int Restar(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }
}
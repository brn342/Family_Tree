namespace Library;

public class NombreMasLargo: IVisitor<Person>
{
    public string NombreLargo { get; private set; } = string.Empty;
    
    public void Visit(Node<Person> node)
    {
        if (node.Content.Nombre.Length > NombreLargo.Length)
        {
            NombreLargo = node.Content.Nombre;
        }
    }
}
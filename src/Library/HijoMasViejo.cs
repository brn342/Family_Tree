namespace Library;

public class HijoMasViejo: IVisitor<Person>
{
    public int EdadMasViejo { get; private set; } = 0;
    
    public void Visit(Node<Person> node)
    {
        // Si el nodo es hoja consideramos su edad
        if (node.Children.Count == 0)
        {
            if (node.Content.Edad > EdadMasViejo)
            {
                EdadMasViejo = node.Content.Edad;
            }
        }
    }

}
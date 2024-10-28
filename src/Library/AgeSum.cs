namespace Library;

public class AgeSum: IVisitor<Person>
{
    public int SumaTotal { get; private set; } = 0;

    public void Visit(Node<Person> node)
    {
        SumaTotal += node.Content.Edad;
    }
}
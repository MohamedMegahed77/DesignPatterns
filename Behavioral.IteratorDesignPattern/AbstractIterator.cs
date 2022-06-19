namespace Behavioral.IteratorDesignPattern
{
    interface AbstractIterator
    {
        Elempoyee First();
        Elempoyee Next();
        bool IsCompleted { get; }
    }
}

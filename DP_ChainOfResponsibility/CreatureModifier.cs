namespace DesignPatterns.ChainOfResponsibility;

public class CreatureModifier
{
    protected Creature creature;
    protected CreatureModifier? next; // Linked list

    public CreatureModifier(Creature creature)
    {
        this.creature = creature ?? throw new ArgumentNullException(paramName: nameof(creature));
    }

    public void Add(CreatureModifier cm)
    {
        if (next != null) next.Add(cm);
        else next = cm;
    }

    public virtual void Handle() => next?.Handle();
}

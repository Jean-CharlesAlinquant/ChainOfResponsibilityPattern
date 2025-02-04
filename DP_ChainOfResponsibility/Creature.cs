namespace DesignPatterns.ChainOfResponsibility;

public class Creature
{
    public string Name;
    public int Attack, Defense;

    public Creature(string name, int attack, int defense)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Attack = attack;
        Defense = defense;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
    }
}

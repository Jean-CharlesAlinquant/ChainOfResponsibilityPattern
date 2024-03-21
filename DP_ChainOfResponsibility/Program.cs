using DesignPatterns.ChainOfResponsibility;

var goblin = new Creature("Goblin", 2, 2);
Console.WriteLine(goblin);

var modifier = new CreatureModifier(goblin);

// uncomment to shortcut the linked list
// modifier.Add(new NoBonusesModifier(goblin));

Console.WriteLine("Let's double the goblin's attack");
modifier.Add(new DoubleAttackModifier(goblin));

Console.WriteLine("Let's increase the goblin's defense");
modifier.Add(new IncreaseDefenseModifier(goblin));

modifier.Handle();
Console.WriteLine(goblin);

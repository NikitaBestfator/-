namespace КТ2;

public class Warrior : Hero, IPhysicalFighter //почему ошибка
{
    public Warrior(string name, int level) : base(name, level)
    {
        
    }
    
    protected override ConsoleColor Color => ConsoleColor.Blue;

    public override void UseAbility()
    {
        Console.WriteLine($"{nameof(IPhysicalFighter)}: Использована способность");
    }

    public void Attack()
    {
        Console.WriteLine($"{nameof(IPhysicalFighter)}: Герой аттакует");
    }
}
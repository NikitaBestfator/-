namespace КТ2;

public class Paladin : Hero, IMagicUser, IPhysicalFighter //почему ошибка
{
    public Paladin(string name, int level):base(name,level)
    {
        
    }
    
    protected override ConsoleColor Color => ConsoleColor.Yellow;
    

    public override void UseAbility()
    {
        Write($"{nameof(Paladin)}: Использовать лечение");
    }

    public void CastSpell()
    {
        Write($"{nameof(IMagicUser)}: Прочитано заклинание");
    }

    public void Attack()
    {
        Write($"{nameof(IPhysicalFighter)}: Герой аттакует");
    }
}
namespace КТ2;

public class HeroManager<T>
where T : Hero
{
    public List<Hero> Heroes = new List<Hero>();
    public void AddHero(T hero)
    {
        Heroes.Add(hero);
    }
    
    public void LevelUpHero(string name)
    {
        var h = Heroes.Find(h => h.Name == name);
        if (h == null)
        {
            Console.WriteLine($"Герой не найден");
            return;
        }

        h.LevelUp();
    }

    public void DisplayHeroes()
    {
        foreach (var hero in Heroes)
        {
            Console.WriteLine($"Все герои {hero.Name}, с уровнями {hero.Level}");
        }
    }
    
}
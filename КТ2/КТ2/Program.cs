using КТ2;

var Bob = new Wizard("Bob", 32);
var Rob = new Wizard("Rob", 65);
var Robert = new Warrior("Robert", 98);
var Carl = new Warrior("Carl", 105);
var Jack = new Paladin("Jack", 76);
var James = new Paladin("James", 43);
var HeroManager = new HeroManager<Hero>();
    
HeroManager.AddHero(Bob);
HeroManager.AddHero(Rob);
HeroManager.AddHero(Robert);
HeroManager.AddHero(Carl);
HeroManager.AddHero(Jack);
HeroManager.AddHero(James);

HeroManager.DisplayHeroes();

foreach (var hero in HeroManager.Heroes)
{
    hero.UseAbility();
    hero.LevelUp();
}

HeroManager.DisplayHeroes();
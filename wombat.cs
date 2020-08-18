  abstract class Being
  {
    public int Health { get; private set; }

    public void TakeDamage(int damage)
    {
      Health -= ProcessDamage(damage);
      if(Health <= 0)
        Console.WriteLine("Я умер");
    }

    public abstract int ProcessDamage(int damage);
  }
  
  class Wombat : Being
  {
    public int Armor { get; private set; }
    
    public override int ProcessDamage(int damage)
    {
      return damage - Armor;
    }
  }
 
  class Human : Being
  {
    public int Agility { get; private set; }
    
    public override int ProcessDamage(int damage)
    {
      return damage / Agility;
    }
  }
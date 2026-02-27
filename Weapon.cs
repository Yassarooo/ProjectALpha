class Weapon
{
    public string Name;
    public int Damage;

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void Attack(Player p)
    {
        p.HP -= this.Damage;
    }
    public void Attack(Monster p)
    {
        p.HP -= this.Damage;
    }
}

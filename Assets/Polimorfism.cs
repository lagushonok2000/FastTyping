using System.Runtime.CompilerServices;
using UnityEngine;

public class Polimorfism : MonoBehaviour
{
    private Spell _currentSpell;
    private void Start()
    {
        Spell fireball = new Fireball(15);
        ChangeSpell(fireball);
        Spell healthSpell = new HealthSpell(10);
        ChangeSpell(healthSpell);
    }

    private void ChangeSpell(Spell spell)
    {
        _currentSpell = spell;
        spell.UseSpell();
    }
}
public class Spell
{
    public int Mana;

    public Spell(int m)
    {
        Mana = m;
    }

    public virtual void UseSpell()
    {
        Debug.Log("Используется заклинание, тратиться маны: " + Mana);
    }
}
public class Fireball: Spell
{
    public Fireball(int m): base (m) { }

    public override void UseSpell()
    {
        Debug.Log("Используется заклинание Fireball, тратиться маны: " + Mana);
    }
}

public class HealthSpell : Spell
{
    public HealthSpell(int m) : base(m) { }

    public override void UseSpell()
    {
        Debug.Log("Используется заклинание HealthSpell, восполняется маны: " + Mana);
    }
}

namespace Models.Battalions;

public class PlayerBattalions {
    public int Wizards {get; set;} = 0;
    public int Warriors {get; set;} = 0;
    public int Rangers {get; set;} = 0;
    public int Archmages {get; set;} = 0;
    public int Cannoneers {get; set;} = 0;
    public int Cavalry {get; set;} = 0;
     
}

public class EnemyBattalions {
    public int Wizards {get; set;} = 0;
    public int Warriors {get; set;} = 0;
    public int Rangers {get; set;} = 0;
     
}

public class Unit {
    public int Health {get; set;} = 0;
    public int MagicOffence {get; set;} = 0;
    public int MagicDefence {get; set;} = 0;
    public int RangeOffence {get; set;} = 0;
    public int RangeDefence {get; set;} = 0;
    public int MeleeOffence {get; set;} = 0;
    public int MeleeDefence {get; set;} = 0;
    public int AttackSpeed {get; set;} = 1000;

}

public class Wizard: Unit {
    public int Health {get; set;} = 8;
    public int MagicOffence {get; set;} = 6;
    public int MagicDefence {get; set;} = 3;
    public int RangeOffence {get; set;} = 0;
    public int RangeDefence {get; set;} = 1;
    public int MeleeOffence {get; set;} = 1;
    public int MeleeDefence {get; set;} = 1;
    public int AttackSpeed {get; set;} = 1000;

}

public class Warrior: Unit {
   public int Health {get; set;} = 12;
    public int MagicOffence {get; set;} = 0;
    public int MagicDefence {get; set;} = 2;
    public int RangeOffence {get; set;} = 1;
    public int RangeDefence {get; set;} = 5;
    public int MeleeOffence {get; set;} = 5;
    public int MeleeDefence {get; set;} = 5;
    public int AttackSpeed {get; set;} = 1000;
}
public class Ranger: Unit {
    public int Health {get; set;} = 10;
    public int MagicOffence {get; set;} = 0;
    public int MagicDefence {get; set;} = 2;
    public int RangeOffence {get; set;} = 5;
    public int RangeDefence {get; set;} = 2;
    public int MeleeOffence {get; set;} = 1;
    public int MeleeDefence {get; set;} = 2;
    public int AttackSpeed {get; set;} = 1000;
}

public class Archmage: Unit {
    public int Health {get; set;} = 10;
    public int MagicOffence {get; set;} = 0;
    public int MagicDefence {get; set;} = 2;
    public int RangeOffence {get; set;} = 5;
    public int RangeDefence {get; set;} = 2;
    public int MeleeOffence {get; set;} = 1;
    public int MeleeDefence {get; set;} = 2;
    public int AttackSpeed {get; set;} = 1000;
}

public class Cannoneer: Unit {
    public int Health {get; set;} = 10;
    public int MagicOffence {get; set;} = 0;
    public int MagicDefence {get; set;} = 2;
    public int RangeOffence {get; set;} = 5;
    public int RangeDefence {get; set;} = 2;
    public int MeleeOffence {get; set;} = 1;
    public int MeleeDefence {get; set;} = 2;
    public int AttackSpeed {get; set;} = 1000;
}

public class Cavalry: Unit {
    public int Health {get; set;} = 10;
    public int MagicOffence {get; set;} = 0;
    public int MagicDefence {get; set;} = 2;
    public int RangeOffence {get; set;} = 5;
    public int RangeDefence {get; set;} = 2;
    public int MeleeOffence {get; set;} = 1;
    public int MeleeDefence {get; set;} = 2;
    public int AttackSpeed {get; set;} = 1000;
}
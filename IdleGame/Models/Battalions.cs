namespace Models.Battalions;


public class Unit {
    public string? Name {get; set;} = "";
    public int Health { get; set; } = 0;
    public int MagicOffence { get; set; } = 0;
    public int MagicDefence { get; set; } = 0;
    public int RangeOffence { get; set; } = 0;
    public int RangeDefence { get; set; } = 0;
    public int MeleeOffence { get; set; } = 0;
    public int MeleeDefence { get; set; } = 0;
    public double? TankEffectiveness {get; set;} = 0.0;
    public int AttackSpeed { get; set; } = 1000;
}

public class Wizard : Unit {
    public Wizard() {
        Name = "Wizard";
        Health = 8;
        MagicOffence = 6;
        MagicDefence = 3;
        RangeOffence = 0;
        RangeDefence = 1;
        MeleeOffence = 1;
        MeleeDefence = 1;
        TankEffectiveness = 0.5;
        AttackSpeed = 1000;
    }
}

public class Warrior : Unit {
    public Warrior() {
        Name = "Warrior";
        Health = 12;
        MagicOffence = 0;
        MagicDefence = 2;
        RangeOffence = 1;
        RangeDefence = 5;
        MeleeOffence = 5;
        MeleeDefence = 5;
        TankEffectiveness = 0.7;
        AttackSpeed = 1000;
    }
}

public class Ranger : Unit {
    public Ranger() {
        Name = "Ranger";
        Health = 10;
        MagicOffence = 0;
        MagicDefence = 2;
        RangeOffence = 5;
        RangeDefence = 2;
        MeleeOffence = 1;
        MeleeDefence = 2;
        TankEffectiveness = 0.5;
        AttackSpeed = 1000;
    }
}

public class Archmage : Unit {
    public Archmage() {
        Name = "Archmage";
        Health = 10;
        MagicOffence = 0;
        MagicDefence = 2;
        RangeOffence = 5;
        RangeDefence = 2;
        MeleeOffence = 1;
        MeleeDefence = 2;
        TankEffectiveness = 0.6;
        AttackSpeed = 1000;
    }
}

public class Cannoneer : Unit {
    public Cannoneer() {
        Name = "Cannoneer";
        Health = 10;
        MagicOffence = 0;
        MagicDefence = 2;
        RangeOffence = 5;
        RangeDefence = 2;
        MeleeOffence = 1;
        MeleeDefence = 2;
        TankEffectiveness = 0.6;
        AttackSpeed = 1000;
    }
}

public class Cavalry : Unit {
    public Cavalry() {
        Name = "Cavalry";
        Health = 10;
        MagicOffence = 0;
        MagicDefence = 2;
        RangeOffence = 5;
        RangeDefence = 2;
        MeleeOffence = 10;
        MeleeDefence = 2;
        TankEffectiveness = 0.75;
        AttackSpeed = 1000;
    }
}

public class TutorialBoss : Unit {
    public TutorialBoss() {
        Name = "Troll Wizard";
        Health = 1000000;
        MagicOffence = 250;
        MagicDefence = 10000;
        RangeOffence = 250;
        RangeDefence = 10000;
        MeleeOffence = 250;
        MeleeDefence = 10000;
        TankEffectiveness = 0.9;
        AttackSpeed = 1000;
    }
}

public class UnitCount<T> where T : Unit, new() {
    public T Unit { get; set; } = new T();
    public int? Count { get; set; } = 0;
    public int? HP {get; set;} 
    public UnitCount() {
        HP = Unit.Health;
    }
}

public class PlayerBattalions {
    public UnitCount<Wizard> Wizards { get; set; } = new UnitCount<Wizard>();
    public UnitCount<Warrior> Warriors { get; set; } = new UnitCount<Warrior>();
    public UnitCount<Ranger> Rangers { get; set; } = new UnitCount<Ranger>();
    public UnitCount<Archmage> Archmages { get; set; } = new UnitCount<Archmage>();
    public UnitCount<Cannoneer> Cannoneers { get; set; } = new UnitCount<Cannoneer>();
    public UnitCount<Cavalry> Cavalry { get; set; } = new UnitCount<Cavalry>();
}
public class EnemyBattalions {
    public UnitCount<Wizard>? Wizards { get; set; } = new UnitCount<Wizard>();
    public UnitCount<Warrior>? Warriors { get; set; } = new UnitCount<Warrior>();
    public UnitCount<Ranger>? Rangers { get; set; } = new UnitCount<Ranger>();
    public UnitCount<Archmage>? Archmages { get; set; } = new UnitCount<Archmage>();
    public UnitCount<Cannoneer>? Cannoneers { get; set; } = new UnitCount<Cannoneer>();
    public UnitCount<Cavalry>? Cavalry { get; set; } = new UnitCount<Cavalry>();
    public UnitCount<TutorialBoss>? TutorialBoss { get; set; } = new UnitCount<TutorialBoss>();
    
}
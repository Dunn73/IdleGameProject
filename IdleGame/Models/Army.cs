using Models.Amunitions;
using Models.Battalions;
using Models.Multipliers;


namespace Models.Army;

public record PlayerArmy {
    public PlayerBattalions? PlayerBattalions {get; set;}
    public WizardMultipliers? WizardMultipliers {get; set;}
    public WarriorMultipliers? WarriorMultipliers {get; set;}
    public RangerMultipliers? RangerMultipliers {get; set;}
    public PlayerAmunitions? PlayerAmunitions {get; set;}

}

public record KingdomArmy {
    public PlayerBattalions? PlayerBattalions {get; set;}
    public WizardMultipliers? WizardMultipliers {get; set;}
    public WarriorMultipliers? WarriorMultipliers {get; set;}
    public RangerMultipliers? RangerMultipliers {get; set;}
    public PlayerAmunitions? PlayerAmunitions {get; set;}
}

public record EnemyArmy {
    public EnemyBattalions? EnemyBattalions {get; set;}
    public WizardMultipliers? WizardMultipliers {get; set;}
    public WarriorMultipliers? WarriorMultipliers {get; set;}
    public RangerMultipliers? RangerMultipliers {get; set;}
     public EnemyAmunitions? EnemyAmunitions {get; set;}
}
namespace Models.Multipliers;
public class UnitMultipliers {
    public int HealthMultiplier { get; set; } = 1;
    public int MagicOffenceMultiplier { get; set; } = 1;
    public int MagicDefenceMultiplier { get; set; } = 1;
    public int RangeOffenceMultiplier { get; set; } = 1;
    public int RangeDefenceMultiplier { get; set; } = 1;
    public int MeleeOffenceMultiplier { get; set; } = 1;
    public int MeleeDefenceMultiplier { get; set; } = 1;
    public int AttackSpeedMultiplier {get; set;} = 1;
}

public class WizardMultipliers : UnitMultipliers {
    
}

public class WarriorMultipliers : UnitMultipliers {
    
}

public class RangerMultipliers : UnitMultipliers {
    
}
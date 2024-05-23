using Models.Battalions;
using Models.Army;
using Models.Amunitions;
using Models.Resources;
using Models.Buildings;
using Models.ProfileInfo;

namespace Models.SaveState;

public record EmptySave {
    public PlayerBattalions PlayerUnits = new(){
        Wizards = new UnitCount<Wizard>(),
        Warriors = new UnitCount<Warrior>(),
        Rangers = new UnitCount<Ranger>(),
        Archmages = new UnitCount<Archmage>(),
        Cannoneers = new UnitCount<Cannoneer>(),
        Cavalry = new UnitCount<Cavalry>()
    };

    public EnemyBattalions EnemyUnits = new(){
        
    };
    public PlayerArmy PlayerArmy = new() {
        PlayerBattalions = new() {
            Wizards = new UnitCount<Wizard>(),
            Warriors = new UnitCount<Warrior>(),
            Rangers = new UnitCount<Ranger>(),
            Archmages = new UnitCount<Archmage>(),
            Cannoneers = new UnitCount<Cannoneer>(),
            Cavalry = new UnitCount<Cavalry>()
        },
        WizardMultipliers = new() {
            HealthMultiplier = 1,
            MagicOffenceMultiplier = 1,
            MagicDefenceMultiplier = 1,
            RangeOffenceMultiplier = 1,
            RangeDefenceMultiplier = 1,
            MeleeOffenceMultiplier = 1,
            MeleeDefenceMultiplier = 1,
            AttackSpeedMultiplier = 1
        },
        WarriorMultipliers = new() {
            HealthMultiplier = 1,
            MagicOffenceMultiplier = 1,
            MagicDefenceMultiplier = 1,
            RangeOffenceMultiplier = 1,
            RangeDefenceMultiplier = 1,
            MeleeOffenceMultiplier = 1,
            MeleeDefenceMultiplier = 1,
            AttackSpeedMultiplier = 1
        },
        RangerMultipliers = new() {
            HealthMultiplier = 1,
            MagicOffenceMultiplier = 1,
            MagicDefenceMultiplier = 1,
            RangeOffenceMultiplier = 1,
            RangeDefenceMultiplier = 1,
            MeleeOffenceMultiplier = 1,
            MeleeDefenceMultiplier = 1,
            AttackSpeedMultiplier = 1
        },
        PlayerAmunitions = new() {
            MagicDust = 0,
            StrengthPotions = 0,
            BarbedArrows = 0
        }
        
    };

    public KingdomArmy KingdomArmy= new() {
        PlayerBattalions = new() {
            Wizards = new UnitCount<Wizard>(),
            Warriors = new UnitCount<Warrior>(),
            Rangers = new UnitCount<Ranger>(),
            Archmages = new UnitCount<Archmage>(),
            Cannoneers = new UnitCount<Cannoneer>(),
            Cavalry = new UnitCount<Cavalry>()
        },
        WizardMultipliers = new() {
            HealthMultiplier = 1,
            MagicOffenceMultiplier = 1,
            MagicDefenceMultiplier = 1,
            RangeOffenceMultiplier = 1,
            RangeDefenceMultiplier = 1,
            MeleeOffenceMultiplier = 1,
            MeleeDefenceMultiplier = 1,
            AttackSpeedMultiplier = 1
        },
        WarriorMultipliers = new() {
            HealthMultiplier = 1,
            MagicOffenceMultiplier = 1,
            MagicDefenceMultiplier = 1,
            RangeOffenceMultiplier = 1,
            RangeDefenceMultiplier = 1,
            MeleeOffenceMultiplier = 1,
            MeleeDefenceMultiplier = 1,
            AttackSpeedMultiplier = 1
        },
        RangerMultipliers = new() {
            HealthMultiplier = 1,
            MagicOffenceMultiplier = 1,
            MagicDefenceMultiplier = 1,
            RangeOffenceMultiplier = 1,
            RangeDefenceMultiplier = 1,
            MeleeOffenceMultiplier = 1,
            MeleeDefenceMultiplier = 1,
            AttackSpeedMultiplier = 1
        },
        PlayerAmunitions = new() {
            MagicDust = 0,
            StrengthPotions = 0,
            BarbedArrows = 0
        }
    };
    public PlayerAmunitions PlayerAmunitions = new() {
        MagicDust = 0,
        StrengthPotions = 0,
        BarbedArrows = 0
    };

    public PlayerResources PlayerResources = new() {
        Wood = 0,
        Stone = 0,
        Copper = 0,
        Tin = 0,
        Iron = 0,
        Coal = 0,
        Feathers = 0,
        Flowers = 0,
    };
    public PlayerBuildings PlayerBuildings = new() {
        Hut = 0,
        Shack = 0,
        TreeHouse = 0,
        Farm = 0
    };
    public PlayerInfo PlayerInfo = new() {
        Title = "",
        Name = "",
        KingdomName = "",
        
    };
}

public record TutorialSave: EmptySave {
    public TutorialSave() : base() {
        PlayerUnits = new PlayerBattalions {
            Wizards = new UnitCount<Wizard>() {Count = 250},
            Warriors = new UnitCount<Warrior>() {Count = 250},
            Rangers = new UnitCount<Ranger>() {Count = 250},
            Archmages = new UnitCount<Archmage>() {Count = 5},
            Cannoneers = new UnitCount<Cannoneer>() {Count = 5},
            Cavalry = new UnitCount<Cavalry>() {Count = 5},
            
        };

        EnemyUnits = new EnemyBattalions {
            Archmages = new UnitCount<Archmage>() {Count = 25},
            TutorialBoss = new UnitCount<TutorialBoss>() {Count = 1}
        };
    }
    
}
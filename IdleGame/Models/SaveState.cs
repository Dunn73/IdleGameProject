using Models.Battalions;
using Models.Army;
using Models.Amunitions;
using Models.Resources;
using Models.Buildings;
using Models.ProfileInfo;

namespace Models.SaveState;

public record EmptySave {
    public PlayerBattalions PlayerUnits = new(){
        Wizards = 0,
        Warriors = 0,
        Rangers = 0,
        Archmages = 0,
        Cannoneers = 0,
        Cavalry = 0
    };
    public PlayerArmy PlayerArmy = new() {
        PlayerBattalions = new() {
            Wizards = 0,
            Warriors = 0,
            Rangers = 0,
            Archmages = 0,
            Cannoneers = 0,
            Cavalry = 0
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
            Wizards = 0,
            Warriors = 0,
            Rangers = 0,
            Archmages = 0,
            Cannoneers = 0,
            Cavalry = 0
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
            Wizards = 250,
            Warriors = 250,
            Rangers = 250,
            Archmages = 25,
            Cannoneers = 25,
            Cavalry = 25
        };
    }
    
}
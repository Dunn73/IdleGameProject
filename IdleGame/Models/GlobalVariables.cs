using Models.SaveState;
namespace Models.GlobalVariables;


// Bool to help force the first render of site to home page, then using navbar navigates to each subpage
public class GlobalBool {
    public bool FirstRender {get; set;} = true;
    public bool Animation {get; set;} = false;
    public bool TimerStarted {get; set;} = false;
}

public class GlobalSave {
    public EmptySave? NewSave {get; set;}
}


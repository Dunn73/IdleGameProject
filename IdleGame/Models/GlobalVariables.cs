using Models.SaveState;
namespace Models.GlobalVariables;


// Bool to help force the first render of site to home page, then using navbar navigates to each subpage
public class GlobalBool {
    public bool FirstRender {get; set;} = true;
    public bool Animation {get; set;} = false;
    public static bool TimerStarted {get; set;} = false;
}

public class GlobalSave {
    public static EmptySave? NewSave {get; set;}
    public static event Action? OnPlayerUnitsChanged;
    public static void NotifyPlayerUnitsChanged() => OnPlayerUnitsChanged?.Invoke();
    public static event Action? OnTimeChanged;
    public static void NotifyTimeChanged() => OnTimeChanged?.Invoke();
    public static event Action? OnPlayerUnitsCreatedOrDestroyed;
    public static void NotifyPlayerUnitsCreatedOrDestroyed() => OnPlayerUnitsCreatedOrDestroyed?.Invoke();
    public static event Action? OnProgressChanged;
    public static void NotifyProgressChanged() => OnProgressChanged?.Invoke();
    public static int ProgressTicks {get; set;} = 0;
}

public class GlobalPage {
    public int PageNumber {get; set;}
}
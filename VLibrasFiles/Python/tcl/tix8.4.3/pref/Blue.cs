using System;
using System.Collections.Generic;

public static class TixScheme
{
    // Renamed the field to avoid ambiguity
    private static readonly Dictionary<string, string> _tixOption = new Dictionary<string, string>();

    public static void SetSchemeColor()
    {
        _tixOption["bg"] = "#9090f0";
        _tixOption["fg"] = "black";

        _tixOption["dark1_bg"] = "#8080d0";
        _tixOption["dark1_fg"] = "black";
        _tixOption["dark2_bg"] = "#7070c0";
        _tixOption["dark2_fg"] = "black";
        _tixOption["inactive_bg"] = "#8080da";
        _tixOption["inactive_fg"] = "black";

        _tixOption["light1_bg"] = "#a8a8ff";
        _tixOption["light1_fg"] = "black";
        _tixOption["light2_bg"] = "#c0c0ff";
        _tixOption["light2_fg"] = "black";

        _tixOption["active_bg"] = _tixOption["dark1_bg"];
        _tixOption["active_fg"] = _tixOption["fg"];
        _tixOption["disabled_fg"] = "gray25";

        _tixOption["input1_bg"] = _tixOption["light1_bg"];
        _tixOption["input2_bg"] = _tixOption["bg"];
        _tixOption["output1_bg"] = _tixOption["light1_bg"];
        _tixOption["output2_bg"] = _tixOption["bg"];
    }
}
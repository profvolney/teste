// Fixed version of the code to address CS0708 error
// Changed the class to be non-static to allow instance members

using System;
using System.Collections.Generic;

public class TixSchemeTK
{
    private Dictionary<string, string> tixOption = new Dictionary<string, string>();

    public void TixSetSchemeColor()
    {
        tixOption["bg"] = "#d9d9d9";
        tixOption["fg"] = "black";

        tixOption["dark1_bg"] = "#c3c3c3";
        tixOption["dark1_fg"] = "black";
        tixOption["dark2_bg"] = "#a3a3a3";
        tixOption["dark2_fg"] = "black";
        tixOption["inactive_bg"] = "#a3a3a3";
        tixOption["inactive_fg"] = "black";

        tixOption["light1_bg"] = "#ececec";
        tixOption["light1_fg"] = "white";
        tixOption["light2_bg"] = "#fcfcfc";
        tixOption["light2_fg"] = "white";

        tixOption["active_bg"] = tixOption["dark1_bg"];
        tixOption["active_fg"] = tixOption["fg"];
        tixOption["disabled_fg"] = "gray55";

        tixOption["input1_bg"] = "#d9d9d9";
        tixOption["input2_bg"] = "#d9d9d9";
        tixOption["output1_bg"] = tixOption["dark1_bg"];
        tixOption["output2_bg"] = tixOption["bg"];

        tixOption["select_fg"] = "black";
        tixOption["select_bg"] = "#c3c3c3";

        tixOption["selector"] = "#b03060";
    }
}

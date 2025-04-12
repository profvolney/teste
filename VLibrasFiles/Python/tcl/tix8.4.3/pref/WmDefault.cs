public static class WmDefault
{
    public static void TixSetSchemeColor()
    {
        // Using a dictionary to store options
        var tixOption = new System.Collections.Generic.Dictionary<string, string>();

        // Simulating the wm_default namespace with a static class
        var wmDefault = new
        {
            Background = "#FFFFFF",
            Foreground = "#000000",
            DisabledBackground = "#C0C0C0",
            Scrollbars = "#D3D3D3",
            TextBackground = "#F5F5F5",
            ActiveBackground = "#ADD8E6",
            ActiveForeground = "#00008B",
            DisabledForeground = "#A9A9A9",
            DisabledTextBackground = "#E0E0E0",
            TextForeground = "#000000",
            SelectForeground = "#FFFFFF",
            SelectBackground = "#0000FF",
            SelectColor = "#FF0000"
        };

        // Setting options
        tixOption["bg"] = wmDefault.Background;
        tixOption["fg"] = wmDefault.Foreground;
        tixOption["dark1_bg"] = "#808080";
        tixOption["inactive_bg"] = wmDefault.DisabledBackground;
        tixOption["inactive_fg"] = "black"; // unused
        tixOption["light1_bg"] = wmDefault.Scrollbars;
        tixOption["light1_fg"] = "white"; // unused
        tixOption["list_bg"] = wmDefault.TextBackground;
        tixOption["active_bg"] = wmDefault.ActiveBackground;
        tixOption["active_fg"] = wmDefault.ActiveForeground;
        tixOption["disabled_fg"] = wmDefault.DisabledForeground;
        tixOption["disabled_bg"] = wmDefault.DisabledTextBackground;
        tixOption["input1_bg"] = wmDefault.TextBackground;
        tixOption["input1_fg"] = wmDefault.TextForeground;
        tixOption["select_fg"] = wmDefault.SelectForeground;
        tixOption["select_bg"] = wmDefault.SelectBackground;
        tixOption["selector"] = wmDefault.SelectColor;

        // Output the options for debugging purposes
        foreach (var option in tixOption)
        {
            Console.WriteLine($"{option.Key}: {option.Value}");
        }
    }
}

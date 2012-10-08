using System;
using System.Collections.Generic;
using System.Web;

public static class Functions
{
    public static void Load(string name)
    {
        return WebPage.RenderPage(name);
    }
}

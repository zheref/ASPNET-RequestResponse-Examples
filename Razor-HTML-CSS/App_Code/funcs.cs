using System;
using System.Collections.Generic;
using System.Web;

public static class AuthData
{
    public const string USERNAME = "zheref";
    public const string PASSWORD = "Altairis";

    public static bool IsLogged(HttpSessionStateBase session)
    {
        return session["username"] != null;
    }
}
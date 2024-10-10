using System;
using System.Collections.Generic;
    public static class Extensions
    {
        public const StringComparison comp = StringComparison.OrdinalIgnoreCase;
        public static bool CaselessEq(this string a, string b) { return a.Equals(b, comp); }
        public static bool CaselessStarts(this string a, string b) { return a.StartsWith(b, comp); }
        public static bool CaselessEnds(this string a, string b) { return a.EndsWith(b, comp); }
        public static bool CaselessContains(this string a, string b) { return a.IndexOf(b, comp) >= 0; }
        public static bool CaselessContains(this List<string> items, string value)
        {
            foreach (string item in items)
            {
                if (item.Equals(value, comp)) return true;
            }
            return false;
        }
        public static bool CaselessContains(this string[] items, string value)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(value, comp)) return true;
            }
            return false;
        }
    public static bool IsOtherVer(this string version)
    {
        if (version == null) return false;
        else if (version.CaselessEnds(".1")) return true;
        else if (version.CaselessEnds(".1.")) return true;
        else if (version.CaselessEnds("1.")) return true;
        else if (version.CaselessEnds("1")) return true;
        else if (version.CaselessEnds(".2")) return true;
        else if (version.CaselessEnds(".2.")) return true;
        else if (version.CaselessEnds("2.")) return true;
        else if (version.CaselessEnds("2")) return true;
        else if (version.CaselessEnds(".3")) return true;
        else if (version.CaselessEnds(".3.")) return true;
        else if (version.CaselessEnds("3.")) return true;
        else if (version.CaselessEnds("3")) return true;
        else if (version.CaselessEnds(".4")) return true;
        else if (version.CaselessEnds(".4.")) return true;
        else if (version.CaselessEnds("4.")) return true;
        else if (version.CaselessEnds("4")) return true;
        else if (version.CaselessEnds(".5")) return true;
        else if (version.CaselessEnds(".5.")) return true;
        else if (version.CaselessEnds("5.")) return true;
        else if (version.CaselessEnds("5")) return true;
        else if (version.CaselessEnds(".6")) return true;
        else if (version.CaselessEnds(".6.")) return true;
        else if (version.CaselessEnds("6.")) return true;
        else if (version.CaselessEnds("6")) return true;
        else if (version.CaselessEnds(".7")) return true;
        else if (version.CaselessEnds(".7.")) return true;
        else if (version.CaselessEnds("7.")) return true;
        else if (version.CaselessEnds("7")) return true;
        else if (version.CaselessEnds(".8")) return true;
        else if (version.CaselessEnds(".8.")) return true;
        else if (version.CaselessEnds("8.")) return true;
        else if (version.CaselessEnds("8")) return true;
        else if (version.CaselessEnds(".9")) return true;
        else if (version.CaselessEnds(".9.")) return true;
        else if (version.CaselessEnds("9.")) return true;
        else if (version.CaselessEnds("9")) return true;
        else return false;
    }
}
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTest
{
#if !UNITY_EDITOR && UNITY_IOS
    private const string PLUGIN_NAME = "__Internal";
#else
    private const string PLUGIN_NAME = "sampleplugin";
#endif
    
    [DllImport(PLUGIN_NAME)]
    public static extern int sum(int a, int b);

    [DllImport(PLUGIN_NAME)]
    public static extern string helloWorld();
}

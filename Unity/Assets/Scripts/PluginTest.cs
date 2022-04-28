using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTest {
    [DllImport ("osx")]
    public static extern int test();

    [DllImport("osx")]
    public static extern string helloWorld();
}

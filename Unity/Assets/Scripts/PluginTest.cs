using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTest {
#if !UNITY_EDITOR && UNITY_IOS
    [DllImport ("__Internal")]
#else
    [DllImport ("sampleplugin")]
#endif
    public static extern int test();

#if !UNITY_EDITOR && UNITY_IOS
    [DllImport ("__Internal")]
#else
    [DllImport ("sampleplugin")]
#endif
    public static extern string helloWorld();
}

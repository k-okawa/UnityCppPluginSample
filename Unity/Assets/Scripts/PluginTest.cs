using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTest {
#if !UNITY_EDITOR && UNITY_IOS 
    [DllImport ("__Internal")]
#else
    [DllImport ("SamplePlugin")]
#endif
    public static extern int test();

#if !UNITY_EDITOR && UNITY_IOS
    [DllImport ("__Internal")]
#else
    [DllImport ("SamplePlugin")]
#endif
    public static extern string helloWorld();
}

using UnityEngine;

public class TestBehaviour : MonoBehaviour {
    void Start() {
        int result = PluginTest.test();
        Debug.Log($"PluginResult:{result}");

        string helloWorld = PluginTest.helloWorld();
        Debug.Log(helloWorld);
    }
}
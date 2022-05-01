using TMPro;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _logText;
    [SerializeField] private TextMeshProUGUI _testText;
    [SerializeField] private TextMeshProUGUI _helloWorldText;
    
    void Start()
    {
        Application.logMessageReceived += Log;
        
        Debug.Log("StartCall");
        
        int result = PluginTest.test();
        Debug.Log($"PluginResult:{result}");
        _testText.text = $"TestResult:{result}";

        string helloWorld = PluginTest.helloWorld();
        Debug.Log(helloWorld);
        _helloWorldText.text = $"HelloWorld:{helloWorld}";
    }

    void Log(string condition, string stackTrace, LogType type)
    {
        _logText.text += $"{condition}\n";
    }
}
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
        
        int result = PluginTest.sum(1, 2);
        Debug.Log($"SumResult:1+2={result}");
        _testText.text = $"SumResult:1+2={result}";

        string helloWorld = PluginTest.helloWorld();
        Debug.Log(helloWorld);
        _helloWorldText.text = $"HelloWorld:{helloWorld}";
    }

    void Log(string condition, string stackTrace, LogType type)
    {
        _logText.text += $"{condition}\n";
    }
}
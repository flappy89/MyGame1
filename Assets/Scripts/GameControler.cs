using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Okbutton;
    public InputField answerField;
    public Text What_Is;
    void Start()
    {
        print("Hello World");
    }
    public void PrintAnswer()
    {
        print(answerField.text);
    }


    // Update is called once per frame
    void Update()
    {

    }
}

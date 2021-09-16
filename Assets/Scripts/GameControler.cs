using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Okbutton;
    public InputField answerField;  // answerInputbox;
    public Text displayText;           // displayText;

    string[] answers;
    string[] question;
    int currentQuestionNumber = 0;
    

    void Start()
    {
        answers = new string[3];
        question = new string[]
        {
            "What is your name?"  ,
            "How old are you?"  ,
            "What is your fav game?"    ,
        };

        displayText.text = question[currentQuestionNumber];

    }
    public void PrintAnswer()
    {
        answers[currentQuestionNumber] = answerField.text;
        answerField.text = "";

        currentQuestionNumber = currentQuestionNumber + 1;

        if (currentQuestionNumber <=2)
        {
            displayText.text = question[currentQuestionNumber];
        }
        else
        {
            displayText.text = answers[0] +
                " age is " + answers[1] +
                " and his favorite game is " + answers[2];
                

            Okbutton.gameObject.SetActive(false);
            answerField.gameObject.SetActive(false);
        }




   /* if(currentQuestionNumber <=2)

        answers[currentQuestionNumber] = answerField.text;
        answerField.text = "";

        print(answerField.text);

        displayText.text = answerField.text;
        answerField.text = "";

        print(answers[0] + answers[1] + answers[2]);

        currentQuestionNumber = currentQuestionNumber + 1;

        displayText.text = question[currentQuestionNumber];
   */


    }
       



    // Update is called once per frame
    void Update()
    {

    }
}

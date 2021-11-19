using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    List<String> userInputArr = new List<String>();

    public InputField userInput;

    private void Start()
    {
        userInput.ActivateInputField();
    }

    public void ReadInput(string userInput)
    {
        userInputArr.Add(userInput);
        this.userInput.text = "";
        this.userInput.ActivateInputField();

        debug();
    }

    void debug()
    {
        foreach (var userInputArr in userInputArr)
        {
            Debug.Log(userInputArr.ToString());
        }
    }
}

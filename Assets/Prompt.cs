using System;
using System.Collections.Generic;
using UnityEngine;

public class Prompt : MonoBehaviour
{
    List<String> userInputArr = new List<String>();

    public void ReadInput(string userInput)
    {
        userInputArr.Add(userInput);

        foreach (var userInputArr in userInputArr)
        {
            Debug.Log(userInputArr.ToString());
        }
    }
}

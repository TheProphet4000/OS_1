using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prompt : MonoBehaviour
{
    public string output, outText, input;

    public GameObject prompt;

    private void Start()
    {
        outText = GetComponent<Out> OutputText
    }
    public void ReadInput(string inText)
    {
        input = inText;
        returnInput();
    }

    void returnInput()
    {
        output = input;

        outText = output;
    }
}

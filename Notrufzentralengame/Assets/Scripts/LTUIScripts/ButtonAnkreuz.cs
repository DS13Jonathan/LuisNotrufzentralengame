using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnkreuz : MonoBehaviour
{
    public Text ButtonText;
    // Start is called before the first frame update
    void Start()
    {
        ButtonText.text = "";
    }
    public void click()
    {
        if(ButtonText.text == "")
        {
            ButtonText.text = "X";
        }
        else
        {
            ButtonText.text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Streetcheck : MonoBehaviour
{
    public InputField inputfield;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inputfield.text == name)
        {
            image = GetComponent<Image>();
            image.color = Color.blue;
        }
        else
        {
            image = GetComponent<Image>();
            image.color = Color.gray;
        }
    }
}

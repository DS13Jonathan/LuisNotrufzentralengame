using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StraßenNamenScript : MonoBehaviour
{
    public InputField StraßeInputField;
    public InputField StadtInputField;
    public InputField Hausnummer;
    public InputField Gebäude;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Check()
    {
        if (StraßeInputField.text == "Alphastraße")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Dampferweg")
        {
            StadtInputField.text = "Dülken";
        }
        else if(StraßeInputField.text == "Eltenerstraße")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Finderstraße")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Fasterstraße")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Gampferweg")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Lustraweg")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Mustangweg")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Osterweg")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Ästenstraße")
        {
            StadtInputField.text = "Dülken";
        }
        else if (StraßeInputField.text == "Ölerstraße")
        {
            StadtInputField.text = "Dülken";
        }


        else if (StraßeInputField.text == "Bärenweg")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Kleinstraße")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Mamutstraße")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Martin-Luther-Straße")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Palmweg")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Quanterstraße")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Rosenstraße")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Olerweg")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Westerweg")
        {
            StadtInputField.text = "Viersen";
        }
        else if (StraßeInputField.text == "Ultrastraße")
        {
            StadtInputField.text = "Viersen";
        }
        else
        {
            StadtInputField.text = "";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartAuswahlScript : MonoBehaviour
{
    public Text GeschlechtsText;
    public string Geschlecht;
    // Start is called before the first frame update
    void Start()
    {
        GeschlechtsText.text = PlayerPrefs.GetString("Geschlecht");
    }
    public void clickAuswahlButtonStart()
    {
    }
    public void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Geschlecht", GeschlechtsText.text);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PersonAuswahl(int index)
    {
        switch (index)
        {
            case 0: GeschlechtsText.text = "männlich"; break;
            case 1: GeschlechtsText.text = "weiblich"; break;
        }
    }

}

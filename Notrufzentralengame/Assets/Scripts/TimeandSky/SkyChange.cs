using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyChange : MonoBehaviour
{
    public Material skyBoxMaterialNormal1;
    public Material skyBoxMaterialNormal2;
    public Material skyBoxMaterialStorm;
    public Material skyBoxMaterialAfternoon;
    public Material skyBoxMaterialmidnight;
    public Material skyBoxMaterialMegasun;

    public int Hour;
    public int Minute;
    public int Secondes;

    public float normalSky = 0;

    public string Minutes;
    public string Seconds;
    public string Hours;

    public Text TimeText;
    public Text TimeTextLeitstelle;
    public Light Sun;

    public Image StartImage;
    public Image MenueImage;
    // Start is called before the first frame update

    void Check()
    {
        if(Hour <= 6 || Hour >= 18) {
            RenderSettings.skybox = skyBoxMaterialmidnight;
            Sun.intensity = 0;
        }
        else if(Hour == 6)
        {
            normalSky = UnityEngine.Random.Range(1, 2);
        }
        else
        {
            if (normalSky == 1)
            {
                RenderSettings.skybox = skyBoxMaterialNormal2;
            }
            else
            {
                RenderSettings.skybox = skyBoxMaterialNormal1;
            }
            Sun.intensity = 1;
        }
    }
    void ChangeSkyMaterial()
    {
        RenderSettings.skybox = skyBoxMaterialNormal1;
    }
    void Start()
    {
        Hour = PlayerPrefs.GetInt("Hour");
        Secondes = PlayerPrefs.GetInt("Seconds");
        Minute = PlayerPrefs.GetInt("Minute");
        ChangeSkyMaterial();
        StartCoroutine(TimeStart());
        Check();
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator TimeStart()
    {
        if (StartImage.gameObject.activeSelf == false && MenueImage.gameObject.activeSelf == false)
        {
            if (Minute == 59)
            {
                Minute = 0;
                if (Hour == 24)
                {
                    Hour = 0;
                }
                else
                {
                    Hour = Hour + 1;
                }
            }
            else
            {
                Minute = Minute + 1;
            }
            if (Hour < 10)
            {
                Hours = "0" + Hour;
            }
            else
            {
                Hours = "" + Hour;
            }
            if (Secondes < 10)
            {
                Seconds = "0" + Secondes;
            }
            else
            {
                Seconds = "" + Secondes;
            }
            if (Minute < 10)
            {
                Minutes = "0" + Minute;
            }
            else
            {
                Minutes = "" + Minute;
            }
            TimeText.text = Hours + ":" + Minutes;
            TimeTextLeitstelle.text = Hours + ":" + Minutes;
            Check();
        }
        yield return new WaitForSeconds(2);
        StartCoroutine(TimeStart());
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Hour", Hour);
        PlayerPrefs.SetInt("Minute", Minute);
        PlayerPrefs.SetInt("Seconds", Secondes);
        PlayerPrefs.Save();
    }
    public void Resetclick()
    {
        PlayerPrefs.DeleteKey("Hour");
        PlayerPrefs.DeleteKey("Minute");
        PlayerPrefs.DeleteKey("Seconds");
        Minute = 0;
        Secondes = 0;
        Hour = 7;
        Check();
        normalSky = UnityEngine.Random.Range(1, 2);
    }
}
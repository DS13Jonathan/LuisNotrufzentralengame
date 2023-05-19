using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Networking;

public class DataSave : MonoBehaviour
{
    public Text DateTimeText;
    public Image StartImage;

    void Start()
    {
        // Datum und Uhrzeit abrufen und als Zeichenfolge speichern
        if (!PlayerPrefs.HasKey("Time")) { DateTimeText.text = "-Keinen Spielstand gefunden-"; }
        DateTimeText.text = PlayerPrefs.GetString("Time");

        // Debug-Log-Ausgabe zur Überprüfung

    }
    private void OnApplicationQuit()
    {
        if (StartImage.gameObject.activeSelf == false)
        {
            DateTime TimeNow = DateTime.Now;
            string Time = TimeNow.ToString();
            PlayerPrefs.SetString("Time", "Letzter Spielstand: \b"+Time);

            PlayerPrefs.Save();
        }
    }
    public void ResetGame()
    {
        PlayerPrefs.SetString("Time","-Keinen Spielstand gefunden-");
        PlayerPrefs.Save();
        DateTimeText.text = PlayerPrefs.GetString("Time");
    }
}

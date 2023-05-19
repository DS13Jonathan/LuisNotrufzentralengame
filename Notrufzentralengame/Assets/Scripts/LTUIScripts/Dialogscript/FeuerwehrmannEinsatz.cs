using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeuerwehrmannEinsatz : MonoBehaviour
{
    public mainScript mainScript;

    public Text EinsatzstichwortText;

    public string Verletzung;

    public bool VerletzungBewustlos;
    public bool VerletzungArmschmerzen;
    public bool VerletzungBeinschmerzen;
    public bool VerletzungPlatzwunde;
    public bool VerletzungKind;
    public bool Verletzungsehen;
    public bool Hausnumbervor;

    public bool Hausnumber;
    public bool Anruferstand;

    public string Geschlechtopfer;

    public string VerletzungBewustlosstring;
    public string VerletzungArmschmerzenstring;
    public string VerletzungBeinschmerzenstring;
    public string VerletzungPlatzwundestring;
    public string VerletzungKindstring;
    public string Verletzungsehenstring;

    public bool VerletzungPuls;

    public string Einsatzsichwort;
    public string Gebäudestring;

    public string Einsatz;

    public int Verletzteint = 0;
    // Start is called before the first frame update
    private void ResetVerletzung()
    {
        mainScript.VerletzungBewusstlos = false;
        mainScript.VerletzungArmschmerzen = false;
        mainScript.VerletzungBeinschmerzen = false;
        mainScript.VerletzungLuft = false;
        VerletzungPlatzwunde = false;
        mainScript.VerletzungPuls = false;
        mainScript.VerletzungKind = false;
        mainScript.Verletzungsehen = true;
    }
    // Start is called before the first frame update
    public void clicked()
    {
        mainScript.VerletzungBewusstlos = false;
        mainScript.VerletzungArmschmerzen = false;
        mainScript.VerletzungBeinschmerzen = false;
        mainScript.VerletzungLuft = false;
        VerletzungPlatzwunde = false;
        mainScript.VerletzungPuls = false;
        mainScript.VerletzungKind = false;
        mainScript.Verletzungsehen = true;
        mainScript.Tragehilfe = false;

        mainScript.Hausnumber = true;
        mainScript.Hausnumbervor = false;
        mainScript.VerletzungHautfarbe = false;
        mainScript.Einsatzsichwort = EinsatzstichwortText.text;
        Einsatzsichwort = EinsatzstichwortText.text;
        mainScript.EingeklemmtePersonen = 0;

        if (Random.Range(1, 3) == 2)
        {
            mainScript.VerletzungBewusstlos = true;

            if (Random.Range(1, 2) == 2)
            {
                mainScript.VerletzungPuls = true;
            }
        }

        if (Einsatzsichwort == "B1")
        {
            int random = Random.Range(1, 7);
            if (random == 1)
            {
                mainScript.Einsatz = "Hier brennt eine Mülltonne.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Eine Mülltonne brennt!";
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Hier kommt Rauch aus einer Mülltonne.";
                mainScript.Verletzteint = 0;
                mainScript.Hausnumber = true;
                mainScript.Gebäudestring = "";
                mainScript.Bandobject = "Eine Mülltonne brennt!";
            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Hier brennt es im Vorgarten.";
                mainScript.Verletzteint = 0;
                mainScript.Hausnumber = true;
                mainScript.Gebäudestring = "";
                mainScript.Bandobject = "Mein Vorgarten brennt!";
            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Es brennt eine kleine Wiese.";
                mainScript.Verletzteint = 0;
                mainScript.Hausnumber = true;
                mainScript.Gebäudestring = "";
            }
            else if (random == 5)
            {
                mainScript.Einsatz = "Ich glaueb das hier eine kleine Wiese brennt.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Eine Wiese brennt!";
            }
            else if (random == 6)
            {
                mainScript.Einsatz = "Hier brennt was.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Eine Wiese brennt hier.";
            }
            else if (random == 6)
            {
                mainScript.Einsatz = "Hier brennt was.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Ein Motorrad brennt hier.";
            }
        }
        else if (Einsatzsichwort == "THL2")
        {
            int random = Random.Range(1, 7);
            if (random == 1)
            {
                int randomfahrzeuge = Random.Range(2, 6);
                mainScript.Einsatz = "Hier sind " + randomfahrzeuge + ", wo Leute nicht rauskommen.";
                mainScript.Verletzteint = Random.Range(1, 11);
                mainScript.EingeklemmtePersonen = Random.Range(3, 11);
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;
                mainScript.Bandobject = "Hier brennt ein Auto.";
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Hier sind viele Autos ineinader gefahren.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;
                mainScript.Bandobject = "Heir brennt nichts.";
            }
        }
        else if (Einsatzsichwort == "RD1 Neugeborendes")
        {
            ResetVerletzung();
            int random = Random.Range(1, 5);
            if (random == 1)
            {
                mainScript.Einsatz = "Meine Frau bekommt gleich ein Kind.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.VerletzungKind = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Unser kleines Kind bekommt keine Luft mehr!";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.VerletzungKind = true;
                mainScript.VerletzungLuft = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Mein neues Kind hat eine komische Hautfarbe!";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.VerletzungHautfarbe = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Ich bekomm gleich ein Kind!";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.VerletzungKind = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 5)
            {
                mainScript.Einsatz = "Unser kleines ist vom Stuhlgefallen.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
        }
        else if (Einsatzsichwort == "Tragehilfe")
        {
            int random = Random.Range(1, 5);
            if (random == 1)
            {
                mainScript.Einsatz = "Brauchen welche, zur Tragehilfe.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.Anruferstand = true;
                mainScript.Tragehilfe = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Hier wir ein LF für eine Tragehilfe gebraucht.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.Anruferstand = true;
                mainScript.Tragehilfe = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Brauche ein LF zur Tragehilfe.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.Anruferstand = true;
                mainScript.Tragehilfe = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Wir brauche, welche für eine Tragehilfe.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.Anruferstand = true;
                mainScript.Tragehilfe = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
            else if (random == 5)
            {
                mainScript.Einsatz = "Baruche ein LF zur Tragehilfe.";
                mainScript.Verletzteint = 1;
                mainScript.Tragehilfe = true;
                mainScript.Gebäudestring = "";
                mainScript.Anruferstand = true;
                mainScript.Bandobject = "Hier brennt doch nichts!";
            }
        }
        else if (Einsatzsichwort == "")
        {
            mainScript.Einsatz = "Fehlercode 001";
        }
        else
        {
            mainScript.Einsatz = "Fehlercode 002";
        }

        mainScript.Anruf();
    }
}

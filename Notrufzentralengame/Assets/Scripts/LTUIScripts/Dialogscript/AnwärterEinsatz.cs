using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnwärterEinsatz : MonoBehaviour
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

        if (Random.Range(1, 5) == 2)
        {
            mainScript.VerletzungBewusstlos = true;
        }
        if (Random.Range(1, 5) == 2)
        {
            mainScript.VerletzungPuls = true;
        }

        if (Einsatzsichwort == "Ölspur")
        {
            mainScript.Bandobject = "Hier brennt nichts";
            int random = Random.Range(1, 7);
            if (random == 1)
            {
                mainScript.Einsatz = "Hier ist eine Ölspur";
                if (Random.Range(1, 10) == 5)
                {
                    mainScript.Verletzteint = Random.Range(1, 3);
                }
                else
                {
                    mainScript.Verletzteint = 0;
                }
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Ein Auto, hat eine Ölspur hinterlassen.";
                if (Random.Range(1, 10) == 5)
                {
                    mainScript.Verletzteint = Random.Range(1, 3);
                }
                else
                {
                    mainScript.Verletzteint = 0;
                }
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;
            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Es liegt Öl auf der Straße.";
                if (Random.Range(1, 10) == 5)
                {
                    mainScript.Verletzteint = Random.Range(1, 3);
                }
                else
                {
                    mainScript.Verletzteint = 0;
                }
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;
            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Öl liegt über die Straße verteilt.";
                if (Random.Range(1, 10) == 5)
                {
                    mainScript.Verletzteint = Random.Range(1, 3);
                }
                else
                {
                    mainScript.Verletzteint = 0;
                }
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false; 
            }
            else if (random == 5)
            {
                mainScript.Einsatz = "Es liegt Öl auf der Straße.";
                if (Random.Range(1, 10) == 5)
                {
                    mainScript.Verletzteint = Random.Range(1, 3);
                }
                else
                {
                    mainScript.Verletzteint = 0;
                }
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;
            }
            else if (random == 6)
            {
                mainScript.Einsatz = "Öl ist über die Fahrbahn verteilt.";
                if (Random.Range(1, 10) == 5)
                {
                    mainScript.Verletzteint = Random.Range(1, 3);
                }
                else
                {
                    mainScript.Verletzteint = 0;
                }
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;
            }
        }
        else if (Einsatzsichwort == "RD1")
        {
            mainScript.Bandobject = "Hier brennt nichts";
            int random = Random.Range(1, 5);
            if (random == 1)
            {
                mainScript.Einsatz = "Hier ist einer hingefallen.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                if (Random.Range(0, 1) == 1)
                {
                    mainScript.Hausnumber = false;
                }
                else
                {
                    mainScript.Hausnumber = true;
                }
                mainScript.Hausnumbervor = true;
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Hier ist ein Fahrradfahrer hingefallen und hat ein paar Schrammen.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                if (Random.Range(0, 1) == 1)
                {
                    mainScript.Hausnumber = false;
                }
                else
                {
                    mainScript.Hausnumber = true;
                }
                mainScript.Hausnumbervor = true;
            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Eine ältere Frau ist umgekippt.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                if (Random.Range(0, 1) == 1)
                {
                    mainScript.Hausnumber = false;
                }
                else
                {
                    mainScript.Hausnumber = true;
                }
            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Es sind 2 E-Rollerfahrer, zusammen geknallt.";
                mainScript.Verletzteint = Random.Range(2, 3);
                mainScript.Gebäudestring = "";
                if (Random.Range(0, 1) == 1)
                {
                    mainScript.Hausnumber = false;
                }
                else
                {
                    mainScript.Hausnumber = true;
                }
                mainScript.Hausnumbervor = true;
            }
        }
        else if (Einsatzsichwort == "TH1")
        {
            mainScript.Bandobject = "Hier brennt nichts";
            int random = Random.Range(1, 6);
            if (random == 1)
            {
                mainScript.Einsatz = "Ein Auto ist gegen einen Baum gefahren.";
                mainScript.Verletzteint = Verletzteint = 0;
                if (Random.Range(0, 1) == 1)
                {
                    mainScript.Hausnumber = false;
                }
                else
                {
                    mainScript.Hausnumber = true;
                }
                mainScript.Hausnumbervor = true;
                mainScript.Gebäudestring = "";
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Eine Person ist seit Tagen in der Wohnung und kommt nicht raus.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = true;
                if (Random.Range(0, 5) == 1)
                {
                    mainScript.VerletzungPuls = false;
                }
                else
                {
                    mainScript.VerletzungPuls = true;
                }
                mainScript.EingeklemmtePersonen = 1;

            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Ein Baum ist umgekippt.";
                if (Random.Range(0, 1) == 1)
                {
                    mainScript.Hausnumber = false;
                }
                else
                {
                    mainScript.Hausnumber = true;
                }
                mainScript.Hausnumbervor = true;
                mainScript.Verletzteint = 0;
                mainScript.EingeklemmtePersonen = mainScript.Verletzteint + Random.Range(-1,2);
                if(mainScript.EingeklemmtePersonen < 0)
                {
                    mainScript.EingeklemmtePersonen = 0;

                }
                mainScript.Gebäudestring = "";
                mainScript.Hausnumber = false;

            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Äste versperren die Fahrbahn.";
                if (Random.Range(0, 1) == 1)
                {
                    mainScript.Hausnumber = false;
                }
                else
                {
                    mainScript.Hausnumber = true;
                }
                mainScript.Verletzteint = 0;
                mainScript.EingeklemmtePersonen = mainScript.Verletzteint;
                mainScript.Gebäudestring = "";

            }
            else if (random == 5)
            {
                mainScript.Einsatz = "Hier ist einer vom Gerüst gestürst.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "Bauhof";

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OberfeuerwehrmannEinsatz : MonoBehaviour
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

        if(Random.Range(1,5) == 2)
        {
            mainScript.VerletzungBewusstlos = true;
        }
        if (Random.Range(1, 5) == 2)
        {
            mainScript.VerletzungPuls = true;
        }

        if (Einsatzsichwort == "B2")
        {
            int random = Random.Range(1, 5);
            if (random == 1)
            {
                mainScript.Einsatz = "Hier brennt ein Auto.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Ein Auto brennt!";
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Hier brennt eine Gartenhütte.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Eine Gartenhütte brennt!";
            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Hier brennt eine Gartenhütte.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Eine Gartenhütte brennt!";
            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Hier brennt ein Baucontainer.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.Bandobject = "Ein Baucontainer brennt!";
            }
        }
        else if (Einsatzsichwort == "THL3")
        {
            int random = Random.Range(1, 5);
            if (random == 1)
            {
                mainScript.Einsatz = "Hier ist ein Auto gegen einen Baum gefharen.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.VerletzungBewusstlos = true;
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.EingeklemmtePersonen = 1;
                mainScript.Bandobject = "Hier brennt nichts.";
            }
            else if (random == 2)
            {
                mainScript.Einsatz = "Hier ist ein Kran umgestürzt.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.EingeklemmtePersonen = 0;
                mainScript.Bandobject = "Hier brennt nichts.";
            }
            else if (random == 3)
            {
                mainScript.Einsatz = "Eine Person hat ein Reh mitgenommen.";
                mainScript.Verletzteint = 0;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.EingeklemmtePersonen = 1;
                mainScript.Bandobject = "Hier brennt nichts.";
            }
            else if (random == 4)
            {
                mainScript.Einsatz = "Ein Auto hat sich überschlagen.";
                mainScript.Verletzteint = 1;
                mainScript.Gebäudestring = "";
                mainScript.Hausnumbervor = true;
                mainScript.Hausnumber = true;
                mainScript.EingeklemmtePersonen = 1;
                mainScript.Bandobject = "Hier brennt nichts";
            }
        }
        else if (Einsatzsichwort == "RD2")
        {
        }
        mainScript.Anruf();
    }
}

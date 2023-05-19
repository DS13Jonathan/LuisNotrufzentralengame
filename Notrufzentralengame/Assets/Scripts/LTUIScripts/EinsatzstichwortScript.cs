using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EinsatzstichwortScript : MonoBehaviour
{
    public AnwärterEinsatz AnwärterEinsatz;
    public FeuerwehrmannEinsatz FeuerwehrmannEinsatz;
    public OberfeuerwehrmannEinsatz OberfeuerwehrmannEinsatz;

    public float Einsatzstichwortwert;
    public Text EinsatzstichwortText;
    public Text TextRang;
    public Text Wert;
    public int RangNutzt;
    // Start is called before the first frame update
    void Start()
    {
        EinsatzstichwortText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Anwaerter()
    {
        float Einsatzstichwort = Random.Range(1, 4);
        //Anwärter
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "Ölspur";
            Einsatzstichwortwert = 1;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "RD1";
            Einsatzstichwortwert = 1;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "TH1";
            Einsatzstichwortwert = 5;
        }
        if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "VU1";
            Einsatzstichwortwert = 5;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        AnwärterEinsatz.clicked();
        RangNutzt = 1;
    }
    public void Feuerwehrmann()
    {
        float Einsatzstichwort = Random.Range(1, 6);
        //Feuerwehrmann
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "B1";
            Einsatzstichwortwert = 5;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "THL2";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "VU2";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "Tragehilfe";
            Einsatzstichwortwert = 5;
        }
        else if (Einsatzstichwort == 5)
        {
            EinsatzstichwortText.text = "RD1 Neugeborendes";
            Einsatzstichwortwert = 5;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        FeuerwehrmannEinsatz.clicked();
        RangNutzt = 2;
    }
    public void Oberfeuerwehrmann()
    {
        float Einsatzstichwort = Random.Range(1, 5);
        //Oberfeuerwehrmann
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "B2";
            Einsatzstichwortwert = 5;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "Beleuchtung";
            Einsatzstichwortwert = 1;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "RD2";
            Einsatzstichwortwert = 5;
        }
        if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "THL3";
            Einsatzstichwortwert = 20;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        OberfeuerwehrmannEinsatz.clicked();
        RangNutzt = 3;
    }
    public void Hauptfeuerwehrmann()
    {
        float Einsatzstichwort = Random.Range(1, 5);
        //Hauptfeuerwehrmann
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "B3";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "VU3";
            Einsatzstichwortwert = 20;
        }

        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "Eisunfall1";
            Einsatzstichwortwert = 5;
        }
        if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "THL4";
            Einsatzstichwortwert = 20;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        RangNutzt = 4;
    }
    public void Unterbrandmeister()
    {
        float Einsatzstichwort = Random.Range(1, 7);
        //Unterbrandmeister
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "P Rettungs aus Höhe oder Tiefe";
            Einsatzstichwortwert = 20;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "B2+P";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "Wassernot1";
            Einsatzstichwortwert = 5;
        }
        else if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "Intensiv1";
            Einsatzstichwortwert = 5;
        }

        else if (Einsatzstichwort == 5)
        {
            EinsatzstichwortText.text = "Krankentransport";
            Einsatzstichwortwert = 1;
        }
        if (Einsatzstichwort == 6)
        {
            EinsatzstichwortText.text = "THL5";
            Einsatzstichwortwert = 30;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        RangNutzt = 5;
    }
    public void Brandmeister()
    {
        float Einsatzstichwort = Random.Range(1, 7);
        //Brandmeister
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "RD2 Kind";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "Wassernot2";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "P Aufzug";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "RD3";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 5)
        {
            EinsatzstichwortText.text = "Intensiv2";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 6)
        {
            EinsatzstichwortText.text = "B ELEKTROANLAGE";
            Einsatzstichwortwert = 20;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        RangNutzt = 6;
    }
    public void Oberbrandmeister()
    {
        float Einsatzstichwort = Random.Range(1, 7);
        //Oberbrandmeister
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "RD4";
            Einsatzstichwortwert = 20;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "Intensiv3";
            Einsatzstichwortwert = 20;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "P verschüttet";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "Eisunfall2";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 5)
        {
            EinsatzstichwortText.text = "Psychosoziale Unterstützung";
            Einsatzstichwortwert = 1;
        }

        else if (Einsatzstichwort == 6)
        {
            EinsatzstichwortText.text = "B3+P";
            Einsatzstichwortwert = 20;
        }
        else 
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        RangNutzt = 7;
    }
    public void Hauptbrandmeister()
    {
        float Einsatzstichwort = Random.Range(1, 8);
        //Hauptbrandmeister
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "Wassernot3";
            Einsatzstichwortwert = 20;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "B Wald";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "B BMA";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "RD5";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 5)
        {
            EinsatzstichwortText.text = "Benzin aus PKW";
            Einsatzstichwortwert = 5;
        }
        else if (Einsatzstichwort == 6)
        {
            EinsatzstichwortText.text = "Betreuung";
            Einsatzstichwortwert = 1;
        }
        else if (Einsatzstichwort == 7)
        {
            EinsatzstichwortText.text = "B4";
            Einsatzstichwortwert = 20;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        RangNutzt = 9;
    }
    public void Brandinspektor()
    {
        float Einsatzstichwort = Random.Range(1, 12);
        //Brandinspektor
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "Absicherung";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "B ABC";
            Einsatzstichwortwert = 50;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "VU Zug";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "B Zug";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 5)
        {
            EinsatzstichwortText.text = "Intensiv 4";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 6)
        {
            EinsatzstichwortText.text = "B5";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 7)
        {
            EinsatzstichwortText.text = "THL ABC";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 8)
        {
            EinsatzstichwortText.text = "MANV1";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 9)
        {
            EinsatzstichwortText.text = "Umwetter";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 10)
        {
            EinsatzstichwortText.text = "Notfallseelsorge";
            Einsatzstichwortwert = 5;
        }
        else if (Einsatzstichwort == 11)
        {
            EinsatzstichwortText.text = "Gebäudeeinsturz";
            Einsatzstichwortwert = 50;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        RangNutzt = 10;
    }
    public void Stadtinspektor()
    {
        float Einsatzstichwort = Random.Range(1, 12);
        //Stadtinspektor
        if (Einsatzstichwort == 1)
        {
            EinsatzstichwortText.text = "Bombenfund";
            Einsatzstichwortwert = 50;
        }
        else if (Einsatzstichwort == 2)
        {
            EinsatzstichwortText.text = "Tauchunfall";
            Einsatzstichwortwert = 10;
        }
        else if (Einsatzstichwort == 3)
        {
            EinsatzstichwortText.text = "Überörtlicher Einsatz";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 4)
        {
            EinsatzstichwortText.text = "MANV2";
            Einsatzstichwortwert = 50;
        }
        else if (Einsatzstichwort == 5)
        {
            EinsatzstichwortText.text = "VU Flugzeug1";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 6)
        {
            EinsatzstichwortText.text = "VU Flugzeug2";
            Einsatzstichwortwert = 50;
        }
        else if (Einsatzstichwort == 7)
        {
            EinsatzstichwortText.text = "B6";
            Einsatzstichwortwert = 30;
        }
        else if (Einsatzstichwort == 8)
        {
            EinsatzstichwortText.text = "B7";
            Einsatzstichwortwert = 50;
        }
        else if (Einsatzstichwort == 9)
        {
            EinsatzstichwortText.text = "P Strom";
            Einsatzstichwortwert = 50;
        }
        else if (Einsatzstichwort == 10)
        {
            EinsatzstichwortText.text = "B Explosion";
            Einsatzstichwortwert = 50;
        }
        else if (Einsatzstichwort == 11)
        {
            EinsatzstichwortText.text = "B Schienen";
            Einsatzstichwortwert = 50;
        }
        Debug.Log(Einsatzstichwortwert);
        Wert.text = Einsatzstichwortwert.ToString();
        RangNutzt = 11;
    }
    public void click()
    {
        Debug.Log("Einsatz");
        if (EinsatzstichwortText.text == "")
        {
            Debug.Log("Einsatz2");
            if (TextRang.text == "Anwärter*in")
            {
                float random = Random.Range(1, 2);
                if(random == 1)
                {
                    Anwaerter();
                }
            }
            else if (TextRang.text == "Feuerwehrmann" || TextRang.text == "Feuerwehrfrau")
            {
                float random = Random.Range(1, 3); 
                if (random == 1)
                {
                    Anwaerter();
                }
                else if(random == 2){
                    Feuerwehrmann();
                }
            }
            else if (TextRang.text == "Oberfeuerwehrmann" || TextRang.text == "Oberfeuerwehrfrau")
            {
                float random = Random.Range(1, 4); 
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                Debug.Log(random);
            }
            else if (TextRang.text == "Hauptfeuerwehrmann" || TextRang.text == "Hauptfeuerwehrfrau")
            {
                float random = Random.Range(1, 5);
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                else if (random == 3)
                {
                    Hauptfeuerwehrmann();
                }
            }
            else if (TextRang.text == "Unterbrandmeister" || TextRang.text == "Unterbrandmeisterin")
            {
                float random = Random.Range(1, 6);
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                else if (random == 4)
                {
                    Hauptfeuerwehrmann();
                }
                else if (random == 5)
                {
                    Unterbrandmeister();
                }
            }
            else if (TextRang.text == "Brandmeister" || TextRang.text == "Brandmeisterin")
            {
                float random = Random.Range(1, 7);
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                else if (random == 4)
                {
                    Hauptfeuerwehrmann();
                }
                else if (random == 5)
                {
                    Unterbrandmeister();
                }
                else if (random == 6)
                {
                    Brandmeister();
                }
            }
            else if (TextRang.text == "Oberbrandmeister" || TextRang.text == "Oberbrandmeisterin")
            {
                float random = Random.Range(1, 8);
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                else if (random == 4)
                {
                    Hauptfeuerwehrmann();
                }
                else if (random == 5)
                {
                    Unterbrandmeister();
                }
                else if (random == 6)
                {
                    Brandmeister();
                }
                else if (random == 7)
                {
                    Oberbrandmeister();
                }
            }
            else if (TextRang.text == "Hauptbrandmeister" || TextRang.text == "Hauptbrandmeisterin")
            {
                float random = Random.Range(1, 9);
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                else if (random == 4)
                {
                    Hauptfeuerwehrmann();
                }
                else if (random == 5)
                {
                    Unterbrandmeister();
                }
                else if (random == 6)
                {
                    Brandmeister();
                }
                else if (random == 7)
                {
                    Oberbrandmeister();
                }
                else if (random == 8)
                {
                    Hauptbrandmeister();
                }
            }
            else if (TextRang.text == "Brandinspektor" || TextRang.text == "Brandinspektorin")
            {
                float random = Random.Range(1, 10);
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                else if (random == 4)
                {
                    Hauptfeuerwehrmann();
                }
                else if (random == 5)
                {
                    Unterbrandmeister();
                }
                else if (random == 6)
                {
                    Brandmeister();
                }
                else if (random == 7)
                {
                    Oberbrandmeister();
                }
                else if (random == 8)
                {
                    Hauptbrandmeister();
                }
                else if (random == 9)
                {
                    Brandinspektor();
                }
            }
            else if (TextRang.text == "Stadtinspektor" || TextRang.text == "Stadtinspektorin" || TextRang.text == "Ende")
            {
                float random = Random.Range(1, 12);
                if (random == 1)
                {
                    Anwaerter();
                }
                else if (random == 2)
                {
                    Feuerwehrmann();
                }
                else if (random == 3)
                {
                    Oberfeuerwehrmann();
                }
                else if (random == 4)
                {
                    Hauptfeuerwehrmann();
                }
                else if (random == 5)
                {
                    Unterbrandmeister();
                }
                else if (random == 6)
                {
                    Brandmeister();
                }
                else if (random == 7)
                {
                    Oberbrandmeister();
                }
                else if (random == 8)
                {
                    Hauptbrandmeister();
                }
                else if (random == 9)
                {
                    Brandinspektor();
                }
                else if (random == 10)
                {
                    Stadtinspektor();
                }
            }
        }
    }
}

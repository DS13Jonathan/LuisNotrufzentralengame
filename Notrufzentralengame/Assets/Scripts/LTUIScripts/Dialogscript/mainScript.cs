using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour
{
    public Anw‰rterEinsatz Anw‰rterEinsatz;
    public FeuerwehrmannEinsatz FeuerwehrmannEinsatz;
    public EinsatzstichwortScript EinsatzstichwortScript;

    public Text ButtonText;
    public Image AnruferImageExample;
    public Text SpeakterTextExample;
    public Text MessageExample;
    public GameObject scrollViewContent;
    public Image NextQuestionImage;
    public Image NextQuestionImagestandt;
    public Image NextQuestionImageMed;
    public Image NextQuestionImageFire;
    public Image NextQuestionImageTHL;

    public Text EinsatzstichwortText;

    public InputField EinsatzstichwortInputField;
    public InputField NameInputField;
    public InputField StraﬂetInputField;
    public InputField OrtInputField;
    public InputField R¸ckrufnummertInputField;

    public string Namestring;
    public string Namestringtext;
    public string Verletzung;
    public int Nameint;
    public int Ortint;
    public int Ortintart;
    public string OrtStraﬂestring;
    public int OrtHausnumberstring;

    public bool VerletzungBewusstlos;
    public bool VerletzungArmschmerzen;
    public bool VerletzungBeinschmerzen;
    public bool VerletzungPlatzwunde;
    public bool VerletzungKind;
    public bool Verletzungsehen;
    public bool Hausnumbervor;
    public bool VerletzungHautfarbe;
    public bool VerletzungLuft;

    public bool reanimationFrage;

    public bool Tragehilfe;

    public bool Hausnumber;

    public string Geschlechtopfer;

    public string VerletzungBewusstlosstring;
    public string VerletzungArmschmerzenstring;
    public string VerletzungBeinschmerzenstring;
    public string VerletzungPlatzwundestring;
    public string VerletzungKindstring;
    public string Verletzungsehenstring; 
    public string VerletzungHautfarbestring;
    public string VerletzungLuftstring;
    public string Bandobject;

    public int EingeklemmtePersonen;

    public bool VerletzungPuls;

    public string Einsatzsichwort;
    public string Geb‰udestring;

    public int Fahrzeugeint;

    public int NextintStand;

    public bool Notruf;
    public bool Question;
    public bool Anruferstand;

    public string Einsatz;

    public Rang Rangscript;

    public static int Verletzteint = 0;
    // Start is called before the first frame update
    void Start()
    {
        Nameint = 0;
        NextQuestionImagestandt.gameObject.SetActive(false);
        NextQuestionImageMed.gameObject.SetActive(false);
        NextQuestionImageFire.gameObject.SetActive(false);
        NextQuestionImage.gameObject.SetActive(false);
        AnruferImageExample.gameObject.SetActive(false);
        StartCoroutine(NewAnrufer());
        Notruf = false;
        Question = true;
    }
    IEnumerator Anruf1()
    {

        Anruferstand = false;
        int randomAnfang = Random.Range(1, 5);
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Hallo, Feuerwehr und Rettungsdienst hier, wie kann ich ihnen helfen?";
        dulpictateImage1.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if (Anruferstand == true)
        {
            if (randomAnfang == 2)
            {
                duplaicatetMessage2.text = "Guten Tag, ich bin auf der " + OrtStraﬂestring + ".";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (randomAnfang == 2)
            {
                duplaicatetMessage2.text = "Guten Tag.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (randomAnfang == 4)
            {
                duplaicatetMessage2.text = "Guten Tag.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (randomAnfang == 4)
            {
                duplaicatetMessage2.text = "Guten Tag, brauche einmal Unterst¸tzung.";
                dulpictateImage2.gameObject.SetActive(true);
            }
        }
        else
        {

            if (randomAnfang == 1)
            {
                duplaicatetMessage2.text = "Hilfe!!!!!";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (randomAnfang == 2)
            {
                duplaicatetMessage2.text = "Guten Tag, ich bin auf der " + OrtStraﬂestring + ".";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (randomAnfang == 3)
            {
                duplaicatetMessage2.text = "Ich brauche dringen Hilfe.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (randomAnfang == 4)
            {
                duplaicatetMessage2.text = "Guten Tag.";
                dulpictateImage2.gameObject.SetActive(true);
            }
        }
        Nameint = 0;
        Question = false;

    }
    // Update is called once per frame
    void Update()
    {
        Einsatzsichwort = EinsatzstichwortText.text;
    }
    public void resetclick()
    {
        if (EinsatzstichwortInputField.text == "" || NameInputField.text == "" || R¸ckrufnummertInputField.text == "" || OrtInputField.text == "" || StraﬂetInputField.text == ""|| Fahrzeugeint == 0)
        {

        }
        else
        {
            NextQuestionImage.gameObject.SetActive(false);
            NextQuestionImagestandt.gameObject.SetActive(false);
            NextQuestionImageMed.gameObject.SetActive(false);
            ButtonText.text = "+49 --- ---------";
            StartCoroutine(reset());
        }
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 64);
    }
    IEnumerator reset()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
        Notruf = false;
        StartCoroutine(NewAnrufer());
    }
    IEnumerator NewAnrufer()
    {
        yield return new WaitForSeconds(1);
        ButtonText.text = "+49 502 " + Random.Range(1000000, 9999999);
        int maxNameTableint = 44;
        int NametextTableint = 3;

        reanimationFrage = false;
        string[] NametextTable = new string[NametextTableint];
        NametextTable[0] = "";
        NametextTable[1] = "Mein Name ist ";
        NametextTable[2] = "Ich heiﬂe ";
        string[] NameTable = new string[maxNameTableint];
        NameTable[0] = "Tim";
        NameTable[1] = "Johann";
        NameTable[2] = "Jonathan";
        NameTable[3] = "Anton";
        NameTable[4] = "Luis";
        NameTable[5] = "Leo";
        NameTable[6] = "Mio";
        NameTable[7] = "Alexander";
        NameTable[8] = "Simon";
        NameTable[9] = "Felix";
        NameTable[10] = "Emil";
        NameTable[11] = "Till";
        NameTable[12] = "Thilo";
        NameTable[13] = "Christian";
        NameTable[14] = "Nils";
        NameTable[15] = "David";
        NameTable[16] = "Luise";
        NameTable[17] = "Lena";
        NameTable[18] = "Marie";
        NameTable[19] = "Alice";
        NameTable[20] = "Hannah";
        NameTable[21] = "Clara";
        NameTable[22] = "Angela";
        NameTable[23] = "Lara";
        NameTable[24] = "Christin";
        NameTable[25] = "Fine";
        NameTable[26] = "Lars";
        NameTable[27] = "Maren";
        NameTable[28] = "Jill";
        NameTable[29] = "Madita";
        NameTable[30] = "Kim";
        NameTable[31] = "Sophia";
        NameTable[32] = "Oscar";
        NameTable[33] = "Karl";
        NameTable[34] = "Fynn";
        NameTable[35] = "Robin";
        NameTable[36] = "Zoe";
        NameTable[37] = "Luise";
        NameTable[38] = "Murat";
        NameTable[39] = "Michael";
        NameTable[40] = "Sandra";
        NameTable[41] = "John";
        NameTable[42] = "Gina-Lisa";
        NameTable[43] = "Lena";

        Namestring = NameTable[Random.Range(0, maxNameTableint)];
        Namestringtext = NametextTable[Random.Range(0, NametextTableint)];


        //1 = Wo?
        //2 = Wo?+Hausnummer
        //3 = Wo?+Straﬂe+Hausnummer
        //4 = Wo?+Umgebung

        Ortint = Random.Range(1, 4);
        int OrtTableStraﬂeint = 23;
        string[] OrtTableStraﬂe = new string[OrtTableStraﬂeint];
        OrtTableStraﬂe[1] = "Alphastraﬂe";
        OrtTableStraﬂe[2] = "B‰renweg";
        OrtTableStraﬂe[3] = "Dampferweg";
        OrtTableStraﬂe[4] = "Eltenerstraﬂe";
        OrtTableStraﬂe[5] = "Fasterstraﬂe";
        OrtTableStraﬂe[6] = "Finderstraﬂe";
        OrtTableStraﬂe[7] = "Gampferweg";
        OrtTableStraﬂe[8] = "Kleinstraﬂe";
        OrtTableStraﬂe[9] = "Lustraweg";
        OrtTableStraﬂe[10] = "Mamutstraﬂe";
        OrtTableStraﬂe[11] = "Martin-Luther-Straﬂe";
        OrtTableStraﬂe[12] = "Mustangweg";
        OrtTableStraﬂe[13] = "Muratstraﬂe";
        OrtTableStraﬂe[14] = "Osterweg";
        OrtTableStraﬂe[15] = "Palmweg";
        OrtTableStraﬂe[16] = "Quanterstraﬂe";
        OrtTableStraﬂe[17] = "Rosenstraﬂe";
        OrtTableStraﬂe[18] = "Ultrastraﬂe";
        OrtTableStraﬂe[19] = "Olerweg";
        OrtTableStraﬂe[20] = "Westerweg";
        OrtTableStraﬂe[21] = "ƒstenstraﬂe";
        OrtTableStraﬂe[22] = "÷lerstraﬂe";

        OrtStraﬂestring = OrtTableStraﬂe[Random.Range(1, OrtTableStraﬂeint)];
        OrtHausnumberstring = Random.Range(0, 200);
        Rangscript.Namecheck = Namestring;
        Rangscript.Straﬂencheck = OrtStraﬂestring;
        Rangscript.Einsatzstichwortcheck = Einsatzsichwort;
        //OrtTablestring
    }
    public void Anruf()
    {
        if(Notruf == false)
        {
            StartCoroutine(Anruf1());
            Notruf = true;
        }
    }

    public void NextQuestionImagefunction()
    {
        if(Notruf == true && Question == false)
        {
            NextQuestionImage.gameObject.SetActive(!NextQuestionImage.gameObject.activeSelf);
        }
    }

    public void NextQuestionMedImagefunction()
    {
        if (Notruf == true && Question == false)
        {
            NextQuestionImageMed.gameObject.SetActive(!NextQuestionImageMed.gameObject.activeSelf);
        }
    }

    public void NextQuestionFireImagefunction()
    {
        if (Notruf == true && Question == false)
        {
            NextQuestionImageFire.gameObject.SetActive(!NextQuestionImageFire.gameObject.activeSelf);
        }
    }
    public void NextQuestionTHLImagefunction()
    {
        if (Notruf == true && Question == false)
        {
            NextQuestionImageTHL.gameObject.SetActive(!NextQuestionImageTHL.gameObject.activeSelf);
        }
    }

    public void NextQuestionImagestandtfunction()
    {
        if (Notruf == true && Question == false)
        {
            NextQuestionImagestandt.gameObject.SetActive(!NextQuestionImagestandt.gameObject.activeSelf);
        }
    }
    public void resetQuestionImage()
    {
        NextQuestionImageTHL.gameObject.SetActive(false);
        NextQuestionImagestandt.gameObject.SetActive(false);
        NextQuestionImageMed.gameObject.SetActive(false);
        NextQuestionImage.gameObject.SetActive(false);
        NextQuestionImageFire.gameObject.SetActive(false);
    }
    public void funktionGeb‰ude()
    {
        resetQuestionImage();
        StartCoroutine(Geb‰udefunction());
    }
    public void funktionWer()
    {
        resetQuestionImage();
        StartCoroutine(Werfunction());
    }
    public void funktionVerletzung()
    {
        resetQuestionImage();
        StartCoroutine(Verletzungfunction());
    }
    public void funktionWo()
    {
        resetQuestionImage();
        StartCoroutine(Wofunction());
    }
    public void funktionWas()
    {
        resetQuestionImage();
        StartCoroutine(Wasfunction());
    }
    public void funktionR¸ckrufnummer()
    {
        resetQuestionImage();
        StartCoroutine(R¸ckrufnummerfunction());
    }
    public void funktionHausnummer()
    {
        resetQuestionImage();
        StartCoroutine(Hausnummerfunction());
    }
    public void funktionStraﬂe()
    {
        resetQuestionImage();
        StartCoroutine(Straﬂefunction());
    }
    public void funktionVerletzte()
    {
        resetQuestionImage();
        StartCoroutine(Verletztefunction());
    }
    public void funktionPersoneingeklemmt()
    {
        resetQuestionImage();
        StartCoroutine(Personeingeklemmtfunction());
    }
    public void funktionPuls()
    {
        resetQuestionImage();
        StartCoroutine(Pulsfunction());
    }
    public void funktionWasbrennt()
    {
        resetQuestionImage();
        StartCoroutine(Wasbrenntfunction());
    }
    public void funktionBewusstlos()
    {
        resetQuestionImage();
        StartCoroutine(Bewusstlosfunction());
    }
    IEnumerator Personeingeklemmtfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Wie viele Personen sind eingeklemmt?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        duplaicatetMessage2.text = "Es sind "+EingeklemmtePersonen+" Personen eingeklemmt.";
        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
    }
    IEnumerator Geb‰udefunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Ist ein besodneres Geb‰ude in der n‰he?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if (Random.Range(1,3)==1)
        {
            if(Random.Range(1,3) == 1)
            {
                duplaicatetMessage2.text = "Nein, nur ein paar Einfamilienh‰user.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else
            {
                duplaicatetMessage2.text = "Nein, nur ein paar Mehrfamilienh‰user.";
                dulpictateImage2.gameObject.SetActive(true);
            }
        }
        else
        {
            int random = Random.Range(1, 6);
            if(random == 1)
            {
                duplaicatetMessage2.text = "Ja, hier ist ein Edeka.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (random == 2)
            {
                duplaicatetMessage2.text = "Ja, hier ist ein Kaufland.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (random == 3)
            {
                duplaicatetMessage2.text = "Ja, hier ist ein Eisdiele.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (random == 4)
            {
                duplaicatetMessage2.text = "Ja, hier ist ein Minto.";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else if (random == 5)
            {
                duplaicatetMessage2.text = "Ja, hier ist ein Spieleland.";
                dulpictateImage2.gameObject.SetActive(true);
            }
        }
        Question = false;
    }
    IEnumerator Verletztefunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Gibt es Verletzte?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if (Tragehilfe == true)
        {
            duplaicatetMessage2.text = "Ist doch egal, schick mal welche aber Flott";
            dulpictateImage2.gameObject.SetActive(true);
        }
        else
        {
            if (Verletzteint == 0)
            {
                duplaicatetMessage2.text = "Nein, es gibt keine Verletzte";
                dulpictateImage2.gameObject.SetActive(true);
            }
            else
            {
                duplaicatetMessage2.text = "Es gibt " + Verletzteint + " Verletzte.";
                dulpictateImage2.gameObject.SetActive(true);
            }
        }
        Question = false;
    }
    IEnumerator Straﬂefunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Wie ist der Straﬂennamen?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        duplaicatetMessage2.text = OrtStraﬂestring+"";
        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
    }
    IEnumerator Hausnummerfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        Question = true;

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Haben sie eine Hausnummer f¸r mich?";
        dulpictateImage1.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if(Hausnumber == true)
        {
            if(Hausnumbervor == true)
            {
                duplaicatetMessage2.text = "Ich vor dem Haus, mit der Hausnummer " + OrtHausnumberstring;
            }
            else
            {
                duplaicatetMessage2.text = "ich bin im Haus mit der Hausnummer " + OrtHausnumberstring;
            }
        }
        else
        {
            duplaicatetMessage2.text = "Hier gibt es kein Haus mit einer Hausnummer.";
        }
        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
    }
    IEnumerator R¸ckrufnummerfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        Question = true;

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Kˆnnen wir sie ¸ber die Nummer, immer erreichen?";
        dulpictateImage1.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if (Random.Range(1, 10) == 1)
        {
            duplaicatetMessage2.text = "Nein, bitte unter: + 49 502 " + Random.Range(1000000, 9999999);
        }
        else
        {
            duplaicatetMessage2.text = "Ja,kˆnnen sie";
        }
        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
    }
    IEnumerator Wofunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        Question = true;

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Wo befinden sie sich?";
        dulpictateImage1.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if(Geb‰udestring == "")
        {
            if (Random.Range(1, 3) == 1 && Hausnumber == true)
            {
                if (Hausnumbervor == true)
                {
                    duplaicatetMessage2.text = "Ich bin auf der " + OrtStraﬂestring + " vor der Hausnummer " + OrtHausnumberstring + ".";
                }
                else
                {

                    duplaicatetMessage2.text = "Ich bin auf der " + OrtStraﬂestring + " im Haus, mit der Hausnummer " + OrtHausnumberstring + ".";
                }
            }
            else
            {
                duplaicatetMessage2.text = "Ich bin auf der " + OrtStraﬂestring + ".";
            }
        }
        else
        {
            duplaicatetMessage2.text = "Ich bin beim " + Geb‰udestring + ".";
        }
        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
        Debug.Log(OrtStraﬂestring);

    }
    IEnumerator Werfunction()
    {
        



        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        Question = true;

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Wie ist ihr Name?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

       if(Nameint == 1)
        {
            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
            Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
            Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
            Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
            duplicatetetyp2.text = "Anrufer*in";
            duplicatetetyp2.color = Color.blue;
            duplaicatetMessage2.text = "Ich habe meinen Namen schon gesagt, ich bin " + Namestring + ".";
            dulpictateImage2.gameObject.SetActive(true);
            Question = false;
        }
        else
        {
            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
            Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
            Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
            Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
            duplicatetetyp2.text = "Anrufer*in";
            duplicatetetyp2.color = Color.blue;
            duplaicatetMessage2.text = Namestringtext + Namestring + ".";
            dulpictateImage2.gameObject.SetActive(true);
            Question = false;
            Nameint = 1;
        }
    }
    IEnumerator Wasbrenntfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Was brennt genau?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        duplaicatetMessage2.text = Bandobject;
        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
        Debug.Log(Einsatz);
    }
    IEnumerator Wasfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Was ist passiert?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        duplaicatetMessage2.text = Einsatz;
        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
        Debug.Log(Einsatz);
    }
    IEnumerator Pulsfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Hat die Person einen Puls?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if (Verletzteint == 0)
        {
            duplaicatetMessage2.text = "Es gibt keine Verletzte.";
        }
        else
        {
            if (VerletzungPuls == true)
            {
                if (Random.Range(1, 3) == 1)
                {
                    duplaicatetMessage2.text = "Nein";
                }
                else
                {
                    duplaicatetMessage2.text = "Nein, es ist kein Puls vorhanden";
                }
                if (Random.Range(1, 3) == 1)
                {
                    yield return new WaitForSeconds(1);

                    contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
                    Image dulpictateImage3 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
                    Text duplicatetetyp3 = Instantiate(SpeakterTextExample, dulpictateImage3.transform, true);
                    Text duplaicatetMessage3 = Instantiate(MessageExample, dulpictateImage3.transform, true);
                    duplicatetetyp2.text = "Anrufer*in";
                    duplicatetetyp2.color = Color.blue;
                    if (VerletzungPuls == true)
                    {
                        duplaicatetMessage3.text = "Was soll ich tuen?";
                        reanimationFrage = true;
                    }
                }
                else
                {
                    yield return new WaitForSeconds(1);

                    contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
                    Image dulpictateImage3 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
                    Text duplicatetetyp3 = Instantiate(SpeakterTextExample, dulpictateImage3.transform, true);
                    Text duplaicatetMessage3 = Instantiate(MessageExample, dulpictateImage3.transform, true);
                    duplicatetetyp2.text = "Anrufer*in";
                    duplicatetetyp2.color = Color.blue;
                    if (VerletzungPuls == true)
                    {
                        duplaicatetMessage3.text = "Ich fange mal an mit der Reanimation.";
                    }
                }
            }
            else
            {
                duplaicatetMessage2.text = "Ja, die Person hat Puls.";
            }
        }

        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
    }
    IEnumerator Verletzungfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Welche Verletzung hat die Person?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if (Tragehilfe == true)
        {
            duplaicatetMessage2.text = "Schick mal welche, ist doch egal welche Verletzungen.";
        }
        else
        {
            if (Verletzteint == 0)
            {
                duplaicatetMessage2.text = "Es gibt keine Verletzte.";
            }
            else if (VerletzungKind == true)
            {
                duplaicatetMessage2.text = "Sie ist schwanger.";
            }
            else if (Verletzung == "" && Verletzungsehen == true && VerletzungPuls == true)
            {
                if (Random.Range(0, 1) == 1)
                {
                    Geschlechtopfer = "Er";
                }
                else
                {
                    Geschlechtopfer = "Sie";
                }
                if (VerletzungBewusstlos == true)
                {
                    VerletzungBewusstlosstring = "bewustlos";
                }
                if (VerletzungArmschmerzen == true)
                {
                    VerletzungArmschmerzenstring = ", Armschmerzen";
                }
                if (VerletzungBeinschmerzen == true)
                {
                    VerletzungBeinschmerzenstring = ", Beinschmerzen";
                }
                if (VerletzungPlatzwunde == true)
                {
                    VerletzungPlatzwundestring = ", eine Platzwunde";
                }
                if (VerletzungHautfarbe == true)
                {
                    VerletzungHautfarbestring = ", eine andere Hautfarbe";
                }
                if (VerletzungLuft == true)
                {
                    VerletzungHautfarbestring = ", keine Luft mehr";
                }
                if (VerletzungBewusstlos == true)
                {
                    VerletzungBewusstlosstring = " bewustlos";
                }
                if (VerletzungArmschmerzen == true || VerletzungBeinschmerzen == true || VerletzungPlatzwunde == true)
                {
                    duplaicatetMessage2.text = Geschlechtopfer + " ist " + VerletzungBewusstlosstring + "und hat" + VerletzungArmschmerzenstring + VerletzungBeinschmerzenstring + VerletzungPlatzwundestring + VerletzungHautfarbestring + ".";
                }
                else
                {
                    if (VerletzungArmschmerzen == true || VerletzungBeinschmerzen == true || VerletzungPlatzwunde == true)
                    {
                        duplaicatetMessage2.text = Geschlechtopfer + " hat " + VerletzungArmschmerzenstring + VerletzungBeinschmerzenstring + VerletzungPlatzwundestring + ".";
                    }
                    else
                    {
                        if (VerletzungArmschmerzen == true || VerletzungBeinschmerzen == true || VerletzungPlatzwunde == true)
                        {
                            duplaicatetMessage2.text = Geschlechtopfer + " hat " + VerletzungArmschmerzenstring + VerletzungBeinschmerzenstring + VerletzungPlatzwundestring + ".";
                        }
                    }
                }
            }
            else if (Verletzungsehen == false && VerletzungPuls == true)
            {
                duplaicatetMessage2.text = "Ich kann die Person nicht sehen.";
            }
            else if (VerletzungPuls == false)
            {
                duplaicatetMessage2.text = "Sie ist reanimationspflichtig.";
            }
            else
            {
                duplaicatetMessage2.text = Verletzung + ".";
            }
            dulpictateImage2.gameObject.SetActive(true);
            Question = false;
            Debug.Log(Einsatz);
        }
    }
    IEnumerator Bewusstlosfunction()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Question = true;
        Image dulpictateImage1 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp1 = Instantiate(SpeakterTextExample, dulpictateImage1.transform, true);
        Text duplaicatetMessage1 = Instantiate(MessageExample, dulpictateImage1.transform, true);
        duplicatetetyp1.text = "Disponent*in";
        duplaicatetMessage1.text = "Ist die Person ansprechbar?";
        dulpictateImage1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 64);
        Image dulpictateImage2 = Instantiate(AnruferImageExample, scrollViewContent.transform, true);
        Text duplicatetetyp2 = Instantiate(SpeakterTextExample, dulpictateImage2.transform, true);
        Text duplaicatetMessage2 = Instantiate(MessageExample, dulpictateImage2.transform, true);
        duplicatetetyp2.text = "Anrufer*in";
        duplicatetetyp2.color = Color.blue;
        if (Verletzteint == 0)
        {
            duplaicatetMessage2.text = "Es gibt keine Verletzte.";
        }
        else
        {
            if (VerletzungBewusstlos == true)
            {
                if (Random.Range(1, 3) == 1)
                {
                    duplaicatetMessage2.text = "Nein";
                }
                else
                {
                    duplaicatetMessage2.text = "Nein, sie ist nicht ansprechbar.";
                }
            }
            else
            {
                duplaicatetMessage2.text = "Ja, sie ist ansprechbar.";
            }
        }

        dulpictateImage2.gameObject.SetActive(true);
        Question = false;
        Debug.Log(Einsatz);
    }
}
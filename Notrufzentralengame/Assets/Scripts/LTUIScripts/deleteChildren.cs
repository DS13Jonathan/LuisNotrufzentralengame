using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleteChildren : MonoBehaviour
{
    public GameObject Obj;
    public mainScript Script;

    public Image Image;

    public InputField EinsatzstichwortInputField;
    public InputField EinsatzstichwortBeschreibungInputField;
    public InputField NameInputField;
    public InputField Stra�etInputField;
    public InputField HausnummertInputField;
    public InputField Geb�udeInputField;
    public InputField OrtBeschreibungInputField;
    public InputField OrtInputField;
    public InputField R�ckrufnummertInputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        if (EinsatzstichwortInputField.text == "" || NameInputField.text == "" || R�ckrufnummertInputField.text == "" || OrtInputField.text == "" || Stra�etInputField.text == "")
        {

        }
        else
        {
            EinsatzstichwortInputField.text = "";
            EinsatzstichwortBeschreibungInputField.text = "";
            NameInputField.text = "";
            Stra�etInputField.text = "";
            HausnummertInputField.text = "";
            Geb�udeInputField.text = "";
            OrtBeschreibungInputField.text = "";
            OrtInputField.text = "";
            R�ckrufnummertInputField.text = "";
            Image.gameObject.SetActive(false);
            if (Script.Question == false)
            {
                Transform[] objChild = Obj.gameObject.transform.GetComponentsInChildren<Transform>();
                for (var i = 0; i < objChild.Length; i++)
                {
                    Transform[] ObjectChild = objChild[i].gameObject.transform.GetComponentsInChildren<Transform>(); ;
                    for (var i2 = 0; i2 < ObjectChild.Length; i2++)
                    {
                        if (ObjectChild[i2].gameObject.name == "Content")
                        {
                        }
                        else
                        {
                            Destroy(ObjectChild[i2].gameObject);
                        }
                    }
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EInsatzstichwortButtonclickScript : MonoBehaviour
{
    public InputField InputField;
    // Start is called before the first frame update
    public void clickButton()
    {
        InputField.text = gameObject.name;
    }
}

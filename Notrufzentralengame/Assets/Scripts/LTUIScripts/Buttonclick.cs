using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttonclick : MonoBehaviour
{
    public Image Image1;
    public Image Image2;
    public int intnumber = 1;
    // Start is called before the first frame update
    public void click()
    {
        intnumber++;
        if (intnumber == 1)
        {
            Image1.gameObject.SetActive(true);
        }
        if (intnumber == 2)
        {
            Image2.gameObject.SetActive(true);
            Image1.gameObject.SetActive(false);
        }
    }
}

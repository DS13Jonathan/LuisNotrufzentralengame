using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageMoveRight : MonoBehaviour
{
    public int Imagenumber = 1;
    public Image Image1;
    public Image Image2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void check()
    {
        if (Imagenumber == 1)
        {
            Image1.gameObject.SetActive(true);
            Image2.gameObject.SetActive(false);
        }
        else if (Imagenumber == 2)
        {
            Image1.gameObject.SetActive(false);
            Image2.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void next()
    {
        if (Imagenumber == 2)
        {
        }
        else
        {

            Imagenumber = Imagenumber + 1;
            check();
        }
    }
    public void back()
    {
        if(Imagenumber == 1)
        {
        }
        else
        {

            Imagenumber = Imagenumber - 1;
            check();
        }
    }
}

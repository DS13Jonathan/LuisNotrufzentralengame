using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lichtschalter : MonoBehaviour
{
    public GameObject Lichtschalteron;
    public GameObject Lichtschalteroff;

    // Start is called before the first frame update
    void Start()
    {
        Lichtschalteron.gameObject.SetActive(false);
        Lichtschalteroff.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

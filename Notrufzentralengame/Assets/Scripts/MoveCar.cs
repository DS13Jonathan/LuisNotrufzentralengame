using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public GameObject Car;
    public Vector3 CarMove;
    // Start is called before the first frame update

    void Update()
    {
       if (Car.name == "Car")
        {
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        Car.transform.position = Car.transform.position + CarMove;
        yield return new WaitForSeconds(.1f);
        StartCoroutine(waiter());
    }
}
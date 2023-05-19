using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FahrzeugButtonRemove : MonoBehaviour
{
    public GameObject scrollViewContent;
    public Button Button;
    public mainScript Script;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void click()
    {
        Script.Fahrzeugeint = Script.Fahrzeugeint - 1;
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();
        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y - 33);
        Destroy(Button.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

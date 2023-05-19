using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarButtonClick : MonoBehaviour {

    public GameObject scrollViewContent;
    public Text ButtonText;
    public Button ButtonExample;
    public Text TextExample;
    public mainScript Script;
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
        Script.Fahrzeugeint = Script.Fahrzeugeint + 1;
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();
        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + 33);
        Button dulpictateButton = Instantiate(ButtonExample, scrollViewContent.transform, true);
        Text dulpictateText = Instantiate(TextExample, dulpictateButton.transform, false);
        dulpictateButton.gameObject.SetActive(true);
        dulpictateText.gameObject.SetActive(true);
        dulpictateText.text = ButtonText.text;
    }
}

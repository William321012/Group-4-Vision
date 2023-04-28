using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option2script : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject dialoguePanel2;
    public TextMeshProUGUI Textfield;

    public GameObject option1;
    public GameObject option2;

    private void Start()
    {
        StartCoroutine(removetext());
    }

    public void SetText(string text)
    {
        dialoguePanel.SetActive(false);
        dialoguePanel2.SetActive(true);
        Textfield.text = text;
        option1.SetActive(false);
        option2.SetActive(false);
        

    }
    IEnumerator removetext()
    {
        yield return new WaitForSeconds(1);
        dialoguePanel2.SetActive(false);
    }


  
    // Start is called before the first frame update
}
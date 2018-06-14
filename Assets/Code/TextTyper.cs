using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTyper : MonoBehaviour
{

    public float letterPause = 0.4f; 
    string message;
    Text textComp;

    void Start()
    {
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        for(; ; ){
            textComp = GetComponent<Text>();
            message = textComp.text;
            textComp.text = "";
            foreach (char letter in message.ToCharArray()){
                textComp.text += letter;
                yield return 0;
                yield return new WaitForSeconds(letterPause);
            }
        }
        
    }
}
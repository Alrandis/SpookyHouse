using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public Animator dialogMenu;


    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        dialogMenu.SetBool("StartDialog", true);
        sentences.Clear();
        foreach(string sentece in dialog.sentences)
        {
            sentences.Enqueue(sentece);
        }
        DiaplayNextSentence();
    }

    public void DiaplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;   
        }
    }

    public void EndDialog()
    {
        dialogMenu.SetBool("StartDialog", false);
        Time.timeScale = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAnimator : MonoBehaviour
{
    public Animator dialogMenu;
    public DialogManager dialogManager;

    public void OnTriggerEnter2D(Collider2D other)
    {
        dialogMenu.SetBool("StartDialog", true);
        FindObjectOfType<DialogTriger>().TrigerDialog();
    }
}

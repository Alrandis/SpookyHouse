using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAnimator : MonoBehaviour
{
    public Animator dialogMenu;
    public DialogManager dialogManager;
    private int value = 0;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (value == 0)
        {
            if (other.GetComponent<PlayerController>())
            {
                dialogMenu.SetBool("StartDialog", true);
                FindObjectOfType<DialogTriger>().TrigerDialog();
                Time.timeScale = 0f;
                value++;
            }
        }      
    }
}

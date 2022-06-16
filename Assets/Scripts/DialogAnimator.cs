using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAnimator : MonoBehaviour
{
    public Animator dialogMenu;
    public DialogManager dialogManager;
    public DialogTriger dialogTriger;
    public Collider2D ghost;
    private int value = 0;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (value == 0 && !ghost)
        {
            if (other.GetComponent<PlayerController>())
            {
                dialogMenu.SetBool("StartDialog", true);
                dialogTriger.TrigerDialog();
                Time.timeScale = 0f;
                value++;
            }
        }      
    }
    private void OnMouseDown()
    {
        dialogMenu.SetBool("StartDialog", true);
        dialogTriger.TrigerDialog();
        Time.timeScale = 0f; 
    }
}

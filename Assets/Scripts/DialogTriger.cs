using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriger : MonoBehaviour
{
    public Dialog dialog;

    public void TrigerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}

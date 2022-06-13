using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriger : MonoBehaviour
{
    public Dialog dialog;

    private void Awake()
    {
        this.gameObject.SetActive(false);
    }

    public void TrigerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}

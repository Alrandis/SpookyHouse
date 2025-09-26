using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerZone : MonoBehaviour
{
    private Transform childObj;
    private void Start()
    {
        childObj = this.transform.GetChild(0);
        childObj.gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>())
        {
            childObj.gameObject.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>())
        {
            childObj.gameObject.SetActive(false);
        }
    }
}

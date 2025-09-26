using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalTrigger : MonoBehaviour
{
    [SerializeField] private BoxCollider2D cristal;
    public void OnTriggerEnter2D(Collider2D other)
    {
        cristal.gameObject.transform.GetComponent<BoxCollider2D>().enabled = true;
    }
}

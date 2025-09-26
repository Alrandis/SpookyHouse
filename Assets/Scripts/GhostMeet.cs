using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GhostMeet : MonoBehaviour
{
    [SerializeField] private GameObject ghostMeet;
    [SerializeField] private GameObject ghostNoMeet;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>())
        {
            ghostMeet.SetActive(true);
            ghostNoMeet.SetActive(false);
        }
    }
}

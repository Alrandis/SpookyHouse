using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLibraly : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    { 
        player.GetComponent<PlayerController>().keyForLibrali = true;
        gameObject.SetActive(false);
    }
}

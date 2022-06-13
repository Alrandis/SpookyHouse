using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLibraly : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    private Transform parent;

    private void Start()
    {
        parent = this.transform.parent;
    }

    private void OnMouseDown()
    { 
        player.GetComponent<PlayerController>().keyForLibrali = true;
        parent.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChest : MonoBehaviour
{

    [SerializeField] private GameObject dialogTriggerIfKey;
    [SerializeField] private GameObject dialogTriggerNotKey;
    [SerializeField] private PlayerController player;
    private Transform parent;
    [SerializeField] private GameObject chest;

    private void Start()
    {
        parent = this.transform.parent;
    }

    private void OnMouseDown()
    { 
        player.GetComponent<PlayerController>().keyForchest = true;
        parent.gameObject.SetActive(false);
        dialogTriggerIfKey.SetActive(true);
        dialogTriggerNotKey.SetActive(false);
        chest.SetActive(true);
        FindObjectOfType<PlayerController>().AddCountKey();

    }
}

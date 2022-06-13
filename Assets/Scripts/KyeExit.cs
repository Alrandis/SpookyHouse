using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeExit : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    private Transform parent;
    private void Start()
    {
        parent = this.transform.parent;
    }

    private void OnMouseDown()
    {
        player.GetComponent<PlayerController>().exitKey = true;
        parent.gameObject.SetActive(false);
    }
}

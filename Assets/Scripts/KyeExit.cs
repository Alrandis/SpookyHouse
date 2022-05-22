using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeExit : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        player.GetComponent<PlayerController>().exitKey = true;
        gameObject.SetActive(false);
    }
}

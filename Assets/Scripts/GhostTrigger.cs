using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    private Transform childObj;
    [SerializeField] private GameObject curScene;
    private void Start()
    {
        childObj = this.transform.GetChild(0);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>())
        {
           if (player.exitKey == true && player.keyForchest == true)
            {
                if (curScene.activeSelf)
                {
                    childObj.gameObject.SetActive(true);
                }
               
                // запуск анимаци изчезания призрака
                // Запуск диалога
                // Запуск чтения записок
            }

           else
            {
                childObj.gameObject.SetActive(false);
            }
        }

    }

}

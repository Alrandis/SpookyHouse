using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFromHouse : MonoBehaviour
{
    [SerializeField] private GameObject goodEnd;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] private GameObject badEnd;
    [SerializeField] private GameObject exitGame;
    [SerializeField] private PlayerController player;
    [SerializeField] private GameObject house;
    private void OnMouseDown()
    {
        house.SetActive(false);
        gameMenu.SetActive(true);
        mainMenu.SetActive(false);
        exitGame.SetActive(true);
        if(player.countScrolls == 7)
        {
            goodEnd.SetActive(true);
        }
        else
        {
            badEnd.SetActive(true);
        }

    }
}

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
    [SerializeField] private AudioSource backraundMusic, menuMusic;
    private void OnMouseDown()
    {
        house.SetActive(false);
        backraundMusic.Stop();
        gameMenu.SetActive(true);
        menuMusic.Stop();
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

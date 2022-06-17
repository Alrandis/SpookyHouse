using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject autors;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] private GameObject house;
    [SerializeField] private AudioSource menuMusic;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ShowAutors()
    {
        autors.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void CloseAutors()
    {
        autors.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ContinueGame()
    {
        //menuMusic.Play();
        house.SetActive(true);
        gameMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void PauseGame()
    {
        house.SetActive(false);
        //menuMusic.Stop();
        gameMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}

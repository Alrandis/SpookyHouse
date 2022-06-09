using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    [SerializeField] private PlayerController player;
    [SerializeField] private Vector2 playerPosition;
    public Joystick joystick;
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneNumber);
        player.GetComponent<PlayerController>().transform.position = playerPosition;
       
    }
}

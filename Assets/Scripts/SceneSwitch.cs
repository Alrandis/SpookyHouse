using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    [SerializeField] private Vector2 playerPosition;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneNumber);
        FindObjectOfType<PlayerController>().PutInPoint(playerPosition);
    }
}

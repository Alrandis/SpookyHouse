using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private int sceneNumber;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera nextCamera;
    [SerializeField] private Vector3 playerPosition;

    private void OnMouseDown()
    { 
        FindObjectOfType<PlayerController>().PutInPoint(playerPosition);
        mainCamera.gameObject.SetActive(false);
        nextCamera.gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    
    [SerializeField] private Vector2 playerPosition;

    private void OnMouseDown()
    { 
        FindObjectOfType<PlayerController>().PutInPoint(playerPosition);
    }
}

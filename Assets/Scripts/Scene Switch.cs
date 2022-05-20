using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private int scene_number;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(scene_number);
    }
}

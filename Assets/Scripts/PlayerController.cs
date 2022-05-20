using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    [SerializeField] private int Move_speed;
   
    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(this.gameObject);
        
    }

    void Update()
    {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Move_speed;
        m_Rigidbody.velocity = direction;
    }
}

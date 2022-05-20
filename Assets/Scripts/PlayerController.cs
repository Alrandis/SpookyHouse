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
        DontDestroyOnLoad(transform.parent.gameObject);
        
    }
    private void FixedUpdate()
    {
        Collider2D[] distanceToActive = Physics2D.OverlapCircleAll(transform.position, 4f);
        foreach(Collider2D obj in distanceToActive)
        {
            if (obj.CompareTag("Interactive"))
            {
                if(obj.transform.childCount > 0)
                {
                    Transform childObj = obj.transform.GetChild(0);
                    childObj.gameObject.SetActive(true);
                    Vector3 distance = childObj.transform.position - transform.position;
                    if (distance.magnitude > 4.5f)
                    {
                        childObj.gameObject.SetActive(false);
                    }
                }      
            }
        }
    }
    private void Update()
    {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Move_speed;
        m_Rigidbody.velocity = direction;

    
    }

}

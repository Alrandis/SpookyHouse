using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    [SerializeField] private int Move_speed;
    public bool keyForchest = false;
    public bool exitKey = false;
    public Joystick joystick;
    [SerializeField] private Text count;
    [SerializeField] private int countKey = 0;


    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();        
    }

    public void PutInPoint(Vector3 playerPosition)
    {
        transform.position = playerPosition;
    }
    public void AddCountKey()
    {
        countKey++;
        count.text = $"{countKey}%";
    }

    //private void FixedUpdate()
    //{
    //    Collider2D[] distanceToActive = Physics2D.OverlapCircleAll(transform.position, 4f);
    //    foreach(Collider2D obj in distanceToActive)
    //    {
    //        if (obj.CompareTag("Door"))
    //        {
    //            if(obj.transform.childCount > 0)
    //            {
    //                Transform childObj = obj.transform.GetChild(0);
    //                childObj.gameObject.SetActive(true);
    //                Vector3 distance = childObj.transform.position - transform.position;
    //                if (distance.magnitude > 4.5f)
    //                {
    //                    childObj.gameObject.SetActive(false);
    //                }
    //            }      
    //        }
    //        if (obj.CompareTag("Interactive"))
    //        {
    //            if (obj.transform.childCount > 0)
    //            {
    //                Transform childObj = obj.transform.GetChild(0);
    //                childObj.gameObject.SetActive(true);
    //                Vector3 distance = childObj.transform.position - transform.position;
    //                if (distance.magnitude > 4.5f)
    //                {
    //                    childObj.gameObject.SetActive(false);
    //                }
    //            }
    //        }
    //        if (obj.CompareTag("ÑlosedDoor") && keyForLibrali == true)
    //        {
    //            if (obj.transform.childCount > 0)
    //            {
    //                Transform childObj = obj.transform.GetChild(0);
    //                childObj.gameObject.SetActive(true);
    //                Vector3 distance = childObj.transform.position - transform.position;
    //                if (distance.magnitude > 4.5f)
    //                {
    //                    childObj.gameObject.SetActive(false);
    //                }
    //            }
    //        }
    //        if (obj.CompareTag("KeyLibraly") && keyForLibrali == false)
    //        {
    //            if (obj.transform.childCount > 0)
    //            {
    //                Transform childObj = obj.transform.GetChild(0);
    //                childObj.gameObject.SetActive(true); 
    //                Vector3 distance = childObj.transform.position - transform.position;
    //                if (distance.magnitude > 4.5f)
    //                {
    //                    childObj.gameObject.SetActive(false);
    //                }
    //            }
    //        }
    //        if (obj.CompareTag("Key") && exitKey == false)
    //        {
    //            if (obj.transform.childCount > 0)
    //            {
    //                Transform childObj = obj.transform.GetChild(0);
    //                childObj.gameObject.SetActive(true);
    //                Vector3 distance = childObj.transform.position - transform.position;
    //                if (distance.magnitude > 4.5f)
    //                {
    //                    childObj.gameObject.SetActive(false);
    //                }
    //            }
    //        }
    //    }
    //}

    private void Update()
    {
        var direction = new Vector2(joystick.Horizontal, joystick.Vertical) * Move_speed;
        Flip();
        m_Rigidbody.velocity = direction;

    
    }
    void Flip()
    {
        if (joystick.Horizontal < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (joystick.Horizontal > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}

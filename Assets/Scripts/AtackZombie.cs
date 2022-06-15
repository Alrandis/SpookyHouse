using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackZombie : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject target;
    [SerializeField] private float t;
    public Animator dialogMenu;
    //public DialogManager dialogManager;
    public DialogTriger dialogTriger;

    private void OnMouseDown()
    { 
        transform.position = player.transform.position;
        t = 0;
        StartCoroutine(Atack());
    }

    IEnumerator Atack()
    {
       
        while (t < 1)
        {
            transform.position = Vector3.Lerp(player.transform.position, target.transform.position, t);
            t += 0.01f;
            yield return null;
        }
        anim.SetBool("Damage", true);
        yield return new WaitForSeconds(3);

        dialogMenu.SetBool("StartDialog", true);
        dialogTriger.TrigerDialog();
        Time.timeScale = 0f;

        Destroy(target.gameObject);
        Destroy(gameObject);
    }   
}

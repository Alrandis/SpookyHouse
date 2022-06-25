using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackZombie : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject target;
    [SerializeField] private float t;
    [SerializeField] private Animator dialogMenu;
    [SerializeField] private AudioSource audioZombieDie;
    [SerializeField] private GameObject frontier;

    public DialogTriger dialogTriger;

    private void OnMouseDown()
    { 
        transform.position = player.transform.position;
        audioZombieDie = GetComponent<AudioSource>();
        t = 0;
        StartCoroutine(Atack());
    }

    IEnumerator Atack()
    {
       
        while (t < 1)
        {
            transform.position = Vector3.Lerp(player.transform.position, target.transform.position, t);
            t += 0.04f;
            yield return null;
        }
        audioZombieDie.Play();
        anim.SetBool("Damage", true);
        yield return new WaitForSeconds(3);

        dialogMenu.SetBool("StartDialog", true);
        FindObjectOfType<PlayerController>().SetBoolStartDialogTrue();
        dialogTriger.TrigerDialog();
        Time.timeScale = 0f;

        Destroy(target.gameObject);
        Destroy(gameObject);
        Destroy(frontier);
    }   
}

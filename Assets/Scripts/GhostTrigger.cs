using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private Transform childObj;
    [SerializeField] private GameObject curScene;
    [SerializeField] private NotesShow notesShow;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject exitFromHouse;

    public Animator dialogMenu;
    public DialogTriger dialogTriger;
    private void Start()
    {
        childObj = this.transform.GetChild(0);
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>())
        {
           if (player.exitKey == true && player.keyForchest == true)
           {
                if (curScene.activeInHierarchy)
                {
                    childObj.gameObject.SetActive(true);
                    notesShow.imagesNote = notesShow.GetComponent<NotesShow>().imagesNote;

                    dialogMenu.SetBool("StartDialog", true);
                    dialogTriger.TrigerDialog();


                    notesShow.noteMenu.SetBool("showNote", true);
                    FindObjectOfType<NotesManager>().ShowNotes(notesShow.imagesNote);
                    Time.timeScale = 0f;

                    anim.SetBool("disapoint", true);
                    exitFromHouse.SetActive(true);

                    Destroy(gameObject, 3);
                }

           }

            else
            {
                if (!curScene.activeInHierarchy)
                {
                    anim.SetBool("disapoint", true);
                    Destroy(gameObject, 2);
                }
            }
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private Transform childObj;
    [SerializeField] private GameObject curScene;
    [SerializeField] private NotesShow notesShow;
    
    float currentValue = 1;
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

                  
                    while (currentValue > 0)
                    {
                        childObj.gameObject.GetComponent<Renderer>().material.color = new Color(202, 202, 202, currentValue);
                        currentValue -= Time.deltaTime;
                    }
                    


                    notesShow.noteMenu.SetBool("showNote", true);
                    FindObjectOfType<NotesManager>().ShowNotes(notesShow.imagesNote);
                    Time.timeScale = 0f;

                    childObj.gameObject.SetActive(false);
                }

            }

            else
            {
                while (currentValue > 0)
                {
                    childObj.gameObject.GetComponent<Renderer>().material.color = new Color(202, 202, 202, currentValue);
                }
                //childObj.gameObject.SetActive(false);
            }
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotesShow : MonoBehaviour
{
    public List<Sprite> imagesNote;
    public List<Sprite> realLangNote;
    public Animator noteMenu;
    public NotesManager notesManager;
    public GameObject ghost;
    private void OnMouseDown()
    {
        if(realLangNote != null)
        {
            ghost.GetComponent<NotesShow>().imagesNote.Add(this.realLangNote[0]);
        }
        noteMenu.SetBool("showNote", true);
        FindObjectOfType<NotesManager>().ShowNotes(imagesNote);
        FindObjectOfType<PlayerController>().AddCountScrolls();
        Time.timeScale = 0f;
        transform.parent.gameObject.SetActive(false);
    }
}


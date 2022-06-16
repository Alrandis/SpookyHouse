using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class NotesManager : MonoBehaviour
{
    public Animator noteMenu;
    public Image imageNote;

    private Queue<Sprite> notes;
    private void Start()
    {
        notes = new Queue<Sprite>();
    }

    public void ShowNotes(List<Sprite> imagesNote)
    {
        noteMenu.SetBool("showNote", true);
        if (imagesNote.Count > 1)
        {
            imagesNote = imagesNote.OrderBy(x => x.name).ToList();
        }
        foreach (Sprite note in imagesNote)
        {
            notes.Enqueue(note);
        }
        DiaplayNextNote();
    }

    public void DiaplayNextNote()
    {
        if (notes.Count == 0)
        {
            CloseNote();
            return;
        }
        Sprite CurNote = notes.Dequeue();

        imageNote.overrideSprite = CurNote;
    }

    public void CloseNote()
    {
        noteMenu.SetBool("showNote", false);
        Time.timeScale = 1f;
    }
}


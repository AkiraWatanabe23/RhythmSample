using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Min(1f)]
    [SerializeField] private float _notesSpeed = 1f;
    [SerializeField] private List<Notes> _notes = new();

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _notes.Add(transform.GetChild(i).gameObject.GetComponent<Notes>());
            _notes[i].NotesSpeed = _notesSpeed;
        }
    }
}

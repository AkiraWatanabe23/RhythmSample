using UnityEngine;

public class Checking : MonoBehaviour
{
    [SerializeField] private RhythmController _rhythmController = default;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Notes notes))
        {
            _rhythmController.Notes = notes;
            notes.IsEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Notes notes))
        {
            notes.IsEnter = false;
        }
    }
}

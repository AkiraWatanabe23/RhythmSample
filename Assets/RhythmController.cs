using UnityEngine;

public class RhythmController : MonoBehaviour
{
    [SerializeField] private int _excellentCount = 0;
    [SerializeField] private int _missCount = 0;

    private Notes _notes = default;

    public Notes Notes { get => _notes; set => _notes = value; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            KeyKodeInput(KeyCode.Z, 0);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            KeyKodeInput(KeyCode.X, 1);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            KeyKodeInput(KeyCode.C, 2);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            KeyKodeInput(KeyCode.V, 3);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            KeyKodeInput(KeyCode.B, 4);
        }
    }

    private void KeyKodeInput(KeyCode key, int lane)
    {
        if (_notes == null)
        {
            return;
        }

        if (Input.GetKeyDown(key))
        {
            if (_notes.IsEnter && _notes.LaneNum == lane)
            {
                _excellentCount++;
                Destroy(_notes.gameObject);

                return;
            }

            _missCount++;
        }
    }
}

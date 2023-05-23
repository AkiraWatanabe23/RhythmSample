using UnityEngine;

public class Notes : MonoBehaviour, INotes
{
    [SerializeField] private int _laneNum = 0;
    [SerializeField] private bool _isEnter = false;

    private Rigidbody2D _rb2d = default;
    private float _verticalValue = 0f;
    private float _notesSpeed = 1f;

    public int LaneNum => _laneNum;
    public bool IsEnter { get => _isEnter; set => _isEnter = value; }
    public float NotesSpeed { get => _notesSpeed; set => _notesSpeed = value; }

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _verticalValue -= Time.deltaTime * _notesSpeed;
    }

    private void FixedUpdate()
    {
        _rb2d.velocity = new Vector2(_rb2d.velocity.x, _verticalValue);

        if (_rb2d.velocity.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    public NotesCondition Action()
    {
        if (_isEnter)
        {
            return NotesCondition.Excellent;
        }

        return NotesCondition.Miss;
    }
}

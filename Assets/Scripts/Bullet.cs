using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb;
    public int id;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Shot(Vector3 direction)
    {
        _rb.AddForce(direction * _speed, ForceMode2D.Impulse);
    }
    
    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _playerSpeed = 1f;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 velocity = new Vector3(x, 0, 0) * _playerSpeed;
        velocity.y = _rb.velocity.y;
        _rb.velocity = velocity;
    }    
}

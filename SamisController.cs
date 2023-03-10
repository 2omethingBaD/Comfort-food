using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamisController : MonoBehaviour
{
    [SerializeField] float playerSpeed = 5f;  //sets player speed
    public Rigidbody2D _rb; //sets up variable for rigid body
    public Vector2 _move;
 

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); //gets rigid body so you dont have to type whole thing
        _rb.gravityScale = 0; //stops player from falling until set to at least 1
    }


    // Update is called once per frame
    void Update()
    {
        //player movement
        _move.x = Input.GetAxisRaw("Horizontal");
        _move.y = Input.GetAxisRaw("Vertical");
    }


    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _move * playerSpeed * Time.fixedDeltaTime);
    }
}
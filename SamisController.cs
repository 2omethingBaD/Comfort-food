using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamisController : MonoBehaviour
{
    [SerializeField] float playerSpeed = 5f;  //sets player speed
    public Rigidbody2D _rb; //sets up variable for rigid body
    public Vector2 _move;//sets up the player movement
    //to set the specific game object to manipulate
    public GameObject _saveInteract;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); //gets rigid body so you dont have to type whole thing
        _rb.gravityScale = 0; //stops player from falling until set to at least 1
    }


    //executes when player leaves a trigger area 
    private void OnTriggerExit2D(Collider2D collision)
    {
        //removes talk indicator(specifically for the save trigger)
        if (collision.gameObject.name == "saveTrig")
        {
            _saveInteract.SetActive(false);
        }
    }


    //executes when player enters a trigger area 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //adds talk indicator(specifically for the save trigger)
        if (collision.gameObject.name == "saveTrig")
        {
            _saveInteract.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //checks for player movement
        _move.x = Input.GetAxisRaw("Horizontal");
        _move.y = Input.GetAxisRaw("Vertical");
    }


    //is called every 50 frames(better for physics stuffs)
    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _move * playerSpeed * Time.fixedDeltaTime);//actually changes your position
    }
}
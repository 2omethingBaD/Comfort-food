using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AC;

public class SamisController : MonoBehaviour
{
    [SerializeField] float _playerSpeed = 5f;  //sets player speed

    public Rigidbody2D _rb; //sets up variable for rigid body
    public Vector2 _move;//sets up the player movement
    public bool _freeze;
    /*sets trigger object to stop action list from running when player exits the trigger
     * (hopefully temporary until a shorter solution is found XP)*/
    public GameObject _trig1;
    public GameObject _trig2;
    public GameObject _trig3;
    public GameObject _trig4;
    public GameObject _trig5;
    public GameObject _trig6;
    public GameObject _trig7;
    public GameObject _trig8;
    public GameObject _trig9;
    public GameObject _trig10;
    //to set the specific game object to manipulate
    public GameObject _speekInteract;
    public GameObject _lookInteract;
    public GameObject _useInteract;
    public GameObject _openInteract;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); //gets rigid body so you dont have to type whole thing
        _rb.gravityScale = 0; //stops player from falling until set to at least 1
    }


    //executes when player enters a trigger area 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //adds talk indicator above player
        if (collision.gameObject.tag == "talk")
        {
            _speekInteract.SetActive(true);
        }
        //adds look indicator above player
        if (collision.gameObject.tag == "look")
        {
            _lookInteract.SetActive(true);
        }
        //adds use indicator above player
        if (collision.gameObject.tag == "use")
        {
            _useInteract.SetActive(true);
        }
        //adds open(for doors) indicator above player
        if (collision.gameObject.tag == "open")
        {
            _openInteract.SetActive(true);
        }

        //stops player from moving while in the freeze trigger
        if (collision.gameObject.name == "FreezeZ")
        {
            _freeze = true;
            Debug.Log("you have entered freeze");
        }
    }


    //executes when player leaves a trigger area 
    private void OnTriggerExit2D(Collider2D collision)
    {
        //hides talk indicator above player
        if (collision.gameObject.tag == "talk")
        {
            _speekInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }
        //hides look indicator above player
        if (collision.gameObject.tag == "look")
        {
            _lookInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }
        //hides use indicator above player
        if (collision.gameObject.tag == "use")
        {
            _useInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }
        //hides open(for doors) indicator above player
        if (collision.gameObject.tag == "open")
        {
            _openInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }

        //allows player to move again
        if (collision.gameObject.name == "FreezeZ")
        {
            _freeze = false;
            Debug.Log("you have left freeze");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (!_freeze)
        {
            //checks for player movement
            _move.x = Input.GetAxisRaw("Horizontal");
            _move.y = Input.GetAxisRaw("Vertical");
        }
    }


    //is called every 50 frames(better for physics stuffs)
    void FixedUpdate()
    {
        if (!_freeze)
        {
            _rb.MovePosition(_rb.position + _move * _playerSpeed * Time.fixedDeltaTime);//actually changes your position
        }
    }
}
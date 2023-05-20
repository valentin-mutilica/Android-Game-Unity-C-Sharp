using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    //For PC arrow keys 
    public float movementSpeed;
    float XInput;
    float YInput;


    //Player
    Rigidbody rb;

    //Score & Win text
    int score = 0;
    public GameObject WinText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //For PC arrow keys 
        XInput = Input.GetAxis("Horizontal");
        YInput = Input.GetAxis("Vertical");


        //If player falls from the map
        if (transform.position.y <= -5f)
        {
            SceneManager.LoadScene(0);
        }
    }

    //Player movement left + right
    private void FixedUpdate()
    {
        rb.AddForce(XInput * movementSpeed, 0, YInput * movementSpeed);
    }



    //Colliding with the last snack and showing the win text
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Snack")
        {
            score++;
            other.gameObject.SetActive(false);

        }

        if(score >= 1)
        {
            WinText.SetActive(true);
        }

    }
}

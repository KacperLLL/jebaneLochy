using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    bool isGrounded = false;
    float  h;
    public float speed, jumpPower;
    public Rigidbody2D rigidbody;
    public GameObject camera;

    void Update()
    {
        //ruch kamery
        camera.transform.position = new Vector3(gameObject.transform.position.x, camera.transform.position.y, camera.transform.position.z);

        h = Input.GetAxisRaw("Horizontal");

        if((isGrounded==true)&&Input.GetKeyDown(KeyCode.Space))
        {
            //skok
            isGrounded = false;
            rigidbody.AddForce(transform.up*jumpPower);
        }

        gameObject.transform.position = new Vector2(transform.position.x + (h * speed), transform.position.y);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        //wykrycie kolizji z ziemia, ustawienie stanu na uziemiony
        if (collision.tag == "ground")
        {
            isGrounded = true;
        }
    }
}

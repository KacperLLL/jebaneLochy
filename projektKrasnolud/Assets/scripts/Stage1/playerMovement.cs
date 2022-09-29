using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    bool isGrounded = false, crouch = false, wslizg= false;
    float  h;
    public float speed, jumpPower;
    public Rigidbody2D rigidbody;
    public GameObject camera;

    void Update()
    {
        //ruch kamery
        camera.transform.position = new Vector3(gameObject.transform.position.x, camera.transform.position.y, camera.transform.position.z);

        h = Input.GetAxisRaw("Horizontal");

        if ((isGrounded == true) && Input.GetKeyDown(KeyCode.Space))
        {
            //skok
            isGrounded = false;
            rigidbody.AddForce(transform.up * jumpPower);
        }

        else if (Input.GetKey(KeyCode.LeftControl)&&(h==0)) 
        {
            crouch = true;
            gameObject.transform.localScale = new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
        }
        else if(Input.GetKey(KeyCode.LeftControl)&&(h!=0))
        {
            wslizg = true;
            gameObject.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, 90f, transform.rotation.w);
            rigidbody.AddForce(Vector2.right * 50f);
        }

        if(!Input.GetKey(KeyCode.LeftControl))
        {
            crouch = false;
            gameObject.transform.localScale = new Vector3(transform.localScale.x, 1f, transform.localScale.z);
        }

        if(wslizg)
        {
            StartCoroutine(wslizgg());
        }

        if(!wslizg)
        {
            gameObject.transform.position = new Vector2(transform.position.x + (h * speed), transform.position.y);
            gameObject.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, 0f, transform.rotation.w);
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        //wykrycie kolizji z ziemia, ustawienie stanu na uziemiony
        if (collision.tag == "ground")
        {
            isGrounded = true;
        }
    }

    IEnumerator wslizgg()
    {
        yield return new WaitForSeconds(2.5f);
        gameObject.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, 0f, transform.rotation.w);
        wslizg = false;
    }
}

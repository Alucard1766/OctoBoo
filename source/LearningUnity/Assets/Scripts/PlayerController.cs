using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{
    public float speed;
    private int count;



    void Start()
    {
        count = 0;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(15.0f, 5.0f, Screen.width, Screen.height), "Count: " + count);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidbody.AddForce(movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count++;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomber : MonoBehaviour
{
    public Transform checkpoint;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Transform>().position = new Vector2(checkpoint.position.x, checkpoint.position.y);
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        }
    }
}

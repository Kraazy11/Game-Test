using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemieshit : MonoBehaviour
{
    public float dmg = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<LifeDemo>().HurtAndReset(dmg);
        }
}

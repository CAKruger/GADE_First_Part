using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiFlag : MonoBehaviour
{
    public bool aiflag = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            aiflag = true;
            this.transform.parent = collision.transform;
            
        }
    }
}

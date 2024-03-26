using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class NewBehaviourScript : MonoBehaviour

{
    public GameObject HomeBase;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.transform.position = HomeBase.transform.position;
            this.transform.parent = null;
        }
           
    }
}

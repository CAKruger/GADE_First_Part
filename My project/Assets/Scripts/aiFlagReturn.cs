using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class aiFlagReturn : MonoBehaviour
{
    public GameObject EnemyBase;
    public Flag flag;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            this.transform.position = EnemyBase.transform.position;
            flag.pDrop = false;
            this.transform.parent = null;
            flag.playerflag = false;
        }


    }
}

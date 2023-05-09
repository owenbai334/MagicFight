using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBattle : MonoBehaviour
{
    public float damage;
    [HideInInspector]
    public Enemy enemy;
    [HideInInspector]
    public Bullet bullet;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
           enemy = other.GetComponent<Enemy>();
        }
        if(other.gameObject.tag == "Bullet"||other.gameObject.tag == "MeetBullet")
        {
           bullet = other.GetComponent<Bullet>();
        }       
    }
    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
           enemy = null;
        }
        if(other.gameObject.tag == "Bullet"||other.gameObject.tag == "MeetBullet")
        {
           bullet = null;
        }    
    }
}

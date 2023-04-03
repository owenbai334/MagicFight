using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public List<Bullet> bullets = new List<Bullet>();
    [HideInInspector]
    public Bullet bullet;
    static GameManager instance;
    public static GameManager Instance { get => instance; set => instance = value; }
    void Awake()
    {
        Instance = this;
        bullet.Init(this);
    }
    void Update()
    {
        if (bullets.Count >= 3)
        {
            ThreeDie();
        }
    }
    void ThreeDie()
    {
        Debug.Log("可以三消了");
        for (int i = bullets.Count - 1; i >= 0; i--)
        {
            bullets[i].Die();
        }
        bullets.Clear();
    }
}

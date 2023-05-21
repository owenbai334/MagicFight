using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHouse : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Main;
    public GameObject CameraPos;
    public GameObject[] BossThings;
    public Material BackGround;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Main.GetComponent<Cinemachine.CinemachineBrain>().enabled = false; 
            Camera.main. orthographicSize = 6;
            Main.transform.position = CameraPos.transform.position;
            Main.GetComponent<Skybox>().material = BackGround;
            for (int i = 0; i < BossThings.Length; i++)
            {
                BossThings[i].SetActive(true);
            }       
            Invoke("GroundAnime",0.5f);
        }
    }
    void GroundAnime()
    {
        Ground.SetActive(true);
    }
}
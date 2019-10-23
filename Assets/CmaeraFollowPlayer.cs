using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmaeraFollowPlayer : MonoBehaviour
{

    public Transform Player;

    void Start()
    {
        // Player = GameObject.Find("Player");
        transform.position = Player.position + new Vector3(0,0,-3);
    }

    void Update()
    {
        transform.position = Player.position + new Vector3(0,0,-3);
        // transform.position 
        // transform.position = Player.position;
    }
}

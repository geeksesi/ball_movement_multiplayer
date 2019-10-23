using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMake : MonoBehaviour
{
    public GameObject Player;
 
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

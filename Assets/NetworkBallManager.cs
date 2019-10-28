using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DarkRift;
using DarkRift.Client;
using DarkRift.Client.Unity;
public class NetworkBallManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The DarkRift client to communicate on.")]
    UnityClient client;

    Dictionary<ushort, BallObject> networkBall = new Dictionary<ushort, BallObject>();

    public void Add(ushort id, BallObject player)
    {
        networkBall.Add(id, player);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    string[] players = new[] { "player1", "player2" };
    void Update()
    {
        transform.position = player.position + offset;
    }
}

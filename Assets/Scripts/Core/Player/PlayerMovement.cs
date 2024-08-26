using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerMovement : NetworkBehaviour
{
    [Header("References")]
    [SerializeField] private InputReader inputReader;
    [SerializeField] private Transform bodyTransform;
    [SerializeField] private Rigidbody2D rb;

    [Header("Settings")]
    [SerializeField] private float movementSpeed = 4f;
    [SerializeField] private float turningRate = 30f;

    public override void OnNetworkSpawn()
    {
        if(!IsOwner) { return; }

    }

    private void Update()
    {
        
    }

    public override void OnNetworkDespawn()
    {
        if(!IsOwner) { return; }
        
    }
}

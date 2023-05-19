using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speeder : MonoBehaviour
{
    [SerializeField] float force;

    bool isSpeeding;

    private void OnCollisionEnter(Collision other)
    {
        Speed(other.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        Speed(other);
    }

    private void Speed(Collider other)
    {
        if (isSpeeding == false &&
            other.transform.CompareTag("Ball") && 
            other.transform.TryGetComponent<BallController>(out var ball))
        {

        }
    }

    private void Reset()
    {
        isSpeeding = false;
    }
}

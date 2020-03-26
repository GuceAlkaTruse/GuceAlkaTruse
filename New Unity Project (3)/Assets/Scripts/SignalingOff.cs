using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalingOff : MonoBehaviour
{
    [SerializeField] private AudioSource _sourceOff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BestRob"))
        {
        }
    }
}

using System.Collections;
using UnityEngine;

public class BeaconVanish : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        gameManager.RemoveBeacon();
    }

}
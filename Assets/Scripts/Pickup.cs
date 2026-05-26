using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    GameManager gameManager;

    void Start()
{
    gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
}

    private void OnTriggerStay(Collider otherObject)
    {
        Debug.Log("Something is touching pickup: " + otherObject.name);

        if (otherObject.CompareTag("Player"))
        {
            Debug.Log("Player picked up object");

            gameManager.currentPickups += 1;

            Destroy(gameObject);
        }
    }
}
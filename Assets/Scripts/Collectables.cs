using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("TEST");
            Invoke("DestroCoolectables", 0.2f);//It will invoke the time of 2 sec then after the object will be destroyed
            // Debug.Log("Ball collided with coin");
        }
    }

    void DestroyCollectables()
    {
        Destroy(this.gameObject); //It will destroy the gameObject
    }
}

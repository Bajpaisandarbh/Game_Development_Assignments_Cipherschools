using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    int childCount = 0;

    [HideInInspector] public bool allCoinsCollected = false;
    [SerializeField] private int x;

    private void Start()
    {
        childCount = transform.childCount;
    }

    private void Update()
    {
        if (transform.childCount < childCount)
        {
            Debug.Log("A child object has been destroyed");

            childCount = transform.childCount;

            if (childCount == 0)
            {
                allCoinsCollected = true;
            }
        }
    }
}
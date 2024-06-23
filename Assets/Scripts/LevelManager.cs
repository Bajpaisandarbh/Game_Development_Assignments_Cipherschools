using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform InstantiatePos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ballPrefab, InstantiatePos.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

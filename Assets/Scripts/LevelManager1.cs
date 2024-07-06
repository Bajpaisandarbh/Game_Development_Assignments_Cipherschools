using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform instatiatePos;
    public CameraFlow cameraFlow;
    void Start()
    {
        GameObject go = Instantiate(ballPrefab, instatiatePos.position, Quaternion.identity);
        cameraFlow.target = go.transform;
    }
}
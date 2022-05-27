using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOve : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 5;
    void Update()
    {
        transform.Translate(new Vector3(-MoveSpeed*Time.deltaTime, 0, 0));
    }
}

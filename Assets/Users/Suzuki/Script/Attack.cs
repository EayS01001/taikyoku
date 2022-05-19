using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject prefabBullet;
    public Transform bulletPoint;
    private float interval = 0.5f;
    private float timer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && timer <= 0.0f)
        {
            Instantiate(prefabBullet, bulletPoint.position, bulletPoint.rotation);

            timer = interval;
        }

        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
    }
}

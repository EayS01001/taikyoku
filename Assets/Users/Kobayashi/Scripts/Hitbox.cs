using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == "obst")
        {
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "Player")
        {
            //ÉvÉåÉCÉÑÅ[ÇÃhpå∏è≠
        }
    }
}
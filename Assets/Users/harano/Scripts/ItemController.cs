using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            // ÉAÉCÉeÉÄÇè¡Ç∑
            Destroy(other.gameObject);
        }
    }
}



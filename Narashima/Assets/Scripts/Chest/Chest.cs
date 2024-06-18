using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Die();
        }
    }

    private void Die() 
    { 
        GetComponent<LootBag>().InstantiateLoot(transform.position); 
        Destroy(gameObject);
        
    }
    
}

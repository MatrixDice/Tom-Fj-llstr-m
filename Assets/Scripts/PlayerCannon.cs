using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCannon : MonoBehaviour
{
    // Update is called once per frame

    [SerializeField] GameObject projectilePrefab;

    void Update()
    {
        // Cannon will shoot
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            print("Tried to shoot");
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            
        }

    }
}

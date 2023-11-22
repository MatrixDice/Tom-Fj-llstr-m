using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] public string brand = "Ingen";


    public void Eat()
    {
        Destroy(gameObject);
    }
}
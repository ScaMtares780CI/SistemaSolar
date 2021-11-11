using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public Transform target;
    public int velocidad;
    
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, velocidad * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ride : MonoBehaviour
{
    [SerializeField] private Transform[] wheels;
    private float rotationSpeed = 300f;
    private bool isRiding;

    private void Start()
    {
        isRiding = true;
    }


    // Update is called once per frame
    private void Update()
    {
        if (!isRiding) return;
        
        foreach (Transform wheel in wheels)
        {
            wheel.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        } 
    }

    public void StopRide()
    {
        isRiding = false;
    }
}

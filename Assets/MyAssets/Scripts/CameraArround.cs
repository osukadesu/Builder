using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArround : MonoBehaviour
{
    [SerializeField] private GameObject arma;
    private float rotationSpeed = 25f;
    void Update()
    {
        transform.RotateAround(arma.transform.position, arma.transform.up, rotationSpeed * Time.deltaTime);
    }
}

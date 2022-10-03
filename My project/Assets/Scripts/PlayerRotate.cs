using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private Transform fronTransform;

void Update()
    {
        transform.LookAt (fronTransform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleBtwCubes: MonoBehaviour
{
    public Transform BlueCube1;
    public Transform BlueCube2;

    void Update()
    {
        transform.position = Vector3.Lerp(BlueCube1.position, BlueCube2.position, 0.5f);
    }
}

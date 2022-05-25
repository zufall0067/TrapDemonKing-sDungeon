using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float noteSpeed = 10f;

    private void Update()
    {
        transform.localPosition += Vector3.left * noteSpeed * Time.deltaTime;
    }
}

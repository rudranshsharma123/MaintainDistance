using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    public float duration = 1.5f;
    public Vector3 endPosition;
    Vector3 startPosition;
    void Awake()
    {
        startPosition = transform.position;
    }
    private void Update()
    {
        float t = 0;
        t += duration * Time.deltaTime;

        transform.position = Vector3.Lerp(startPosition, endPosition, t);

    }
}

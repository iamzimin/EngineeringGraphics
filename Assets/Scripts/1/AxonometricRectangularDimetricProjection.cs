using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxonometricRectangularDimetricProjection : MonoBehaviour
{
    // Задание 1

    public float posX = 0f;
    public float posY = -15f;
    public float posZ = 0f;

    public float angleX = 7f;
    public float angleY = -110f;
    public float angleZ = 20f;
    public float os = 60f;

    private Transform t;
    private void Start()
    {
        t = this.GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = new Vector3(posX, posY, posZ);

        t.rotation = Quaternion.Euler(angleX, angleY, angleZ);

        Camera.main.orthographic = true;
        Camera.main.orthographicSize = os;
    }
}

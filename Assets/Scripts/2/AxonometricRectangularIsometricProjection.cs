using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxonometricRectangularIsometricProjection : MonoBehaviour
{
    // Задание 2

    public float posX = -10f;
    public float posY = -25f;
    public float posZ = 0f;

    public float angleX = 23f;
    public float angleY = -135f;
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

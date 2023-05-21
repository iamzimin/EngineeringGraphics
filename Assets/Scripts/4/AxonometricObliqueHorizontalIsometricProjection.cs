using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxonometricObliqueHorizontalIsometricProjection : MonoBehaviour
{
    // Задание 4

    public float posX = -5f;
    public float posY = -10f;
    public float posZ = 0f;

    public float angleX = 58f;
    public float angleY = -111f;
    public float angleZ = 65f;
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

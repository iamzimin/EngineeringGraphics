using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxonometricObliqueFrontalIsometricProjection : MonoBehaviour
{
    // Задание 3

    public float posX = 0f;
    public float posY = -25f;
    public float posZ = 0f;

    public float angleX = 1f;
    public float angleY = -100f;
    public float angleZ = 10f;
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

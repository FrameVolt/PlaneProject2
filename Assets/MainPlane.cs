using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlane : MonoBehaviour {
    [SerializeField]
    private float speed = 1f;

    private int hp = 100;

    private Vector3 direction;
    private float v;

    private float MaxX;
    private float MinX;
    private float MaxY;
    private float MinY;

    private void Start()
    {
        MaxX = ScreenXY.MaxX;
        MinX = ScreenXY.MinX;
        MaxY = ScreenXY.MaxY;
        MinY = ScreenXY.MinY;
    }


    void Update () {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));


        Move(direction);

        ClampFrame();
    }


    private void Move(Vector3 direction) {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void ClampFrame() {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinX, MaxX),
                                     Mathf.Clamp(transform.position.y, MinY, MaxY),
                                     transform.position.z);
    }
}

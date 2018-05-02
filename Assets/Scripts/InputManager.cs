using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager> {
    [SerializeField]
    private MainPlane mainPlane;

    private void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            mainPlane.FireOnce();
        } else if (Input.GetButton("Jump")) {
            mainPlane.FireStart();
        }
    }
}

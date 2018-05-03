using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager> {
    public event Action OnSpaceDown;
    public event Action OnSpace;
    public event Action<Vector3> OnMovement;

    private void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            if(OnSpaceDown != null)
            OnSpaceDown.Invoke();

        } else if (Input.GetButton("Jump")) {
            if (OnSpace != null) {
                OnSpace.Invoke();
            }
        }

        if (OnMovement != null) {
            OnMovement.Invoke(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0));
        }

    }

}

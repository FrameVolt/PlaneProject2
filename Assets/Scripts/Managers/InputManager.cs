using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : PersistentSingleton<InputManager> {
    public event Action OnSpaceDown;
    public event Action OnSpace;
    public event Action<Vector3> OnMovement;
    public event Action OnEsc;

    private void Update()
    {
        
        if (Input.GetButtonDown("Esc")) {
            Esc();
        }

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


    public void Esc() {
        if (OnEsc != null)
            OnEsc.Invoke();
    }

}

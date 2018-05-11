using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentSingleton<T> : MonoBehaviour where T : Component {

    protected static T instance;

    public static T Instance
    {
        get
        {

            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    Debug.LogWarning("there is no " + typeof(T).ToString() + "in the scene.");

                }

            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);

        }
        else {
            if (this != instance) {
                Destroy(this.gameObject);
            }
        }

    }

}

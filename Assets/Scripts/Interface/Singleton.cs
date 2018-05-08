using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static bool applicationIsQuitting = false;
    private static object _lock = new object();
    protected static T instance;

    public static T Instance
    {
        get
        {
            if (applicationIsQuitting)
            {
                return null;
            }
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                //lock (_lock)
                //{
                    if (instance == null)
                    {
                        Debug.LogWarning("there is no " + typeof(T).ToString() + "in the scene.");
                    //GameObject obj = new GameObject();
                    //instance = obj.AddComponent<T>();
                    }
                //}
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        instance = this as T;
    }


    protected virtual void OnDestroy()
    {
        applicationIsQuitting = true;
    }
}
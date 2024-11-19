using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                DontDestroyOnLoad(_instance.gameObject);
            }

            if (_instance == null)
            {
            }
            
            return _instance;
        }
    }

    protected void Awake()
    {
        if (this != Instance)
        {
            Destroy(gameObject);
        }
    }

    protected void SingletonInit()
    {
        _instance = GetComponent<T>();
        DontDestroyOnLoad(gameObject);
    }
}

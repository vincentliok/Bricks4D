﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour // Singleton must be a MonoBehaviour class.
{
    private static T _instance; // Backing variable

    public static T Instance // Property
    {
        get // This property only has a Getter, not a Setter
        {
            if (_instance == null)
            {
                // The code in this block will only be run once, the first time the singleton is requested.

                _instance = FindObjectOfType(typeof(T)) as T; // Check whether we already have an instance of this singleton somewhere else.

                if (_instance == null) // If there is no instance in the hierarchy, create one in code.
                {
                    T obj = new GameObject().AddComponent<T>();
                    _instance = obj as T;
                }

                DontDestroyOnLoad(_instance); // Make instance persistent between scenes.
            }

            return _instance;
        }
    }
}

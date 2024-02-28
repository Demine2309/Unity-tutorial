using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrderDemo : MonoBehaviour
{
    private void Awake()
    {
        //Initialize self
        print("Awake");
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    void Start()
    {
        //Init stuff which refers to other GameObjects
        //Called when Awake() of all GOs were called
        print("Start");
    }


    //void Update()
    //{
    //    print("Update");
    //}
    //private void FixedUpdate()
    //{
    //    print("FixedUpdate");
    //}

    //private void LateUpdate()
    //{
    //    //Called when Update() of all GOs were called
    //    print("LateUpdate");
    //}

    private void OnDestroy()
    {
        //When GameObject is destroyed
        print("OnDestroy");
    }

    private void OnApplicationQuit()
    {
        //Save game before quitting i.e. Elden Ring, Dont starve together etc.
        print("OnApplicationQuit");
    }

}

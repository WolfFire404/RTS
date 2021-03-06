﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than on BuildManager in scene");
        }
        instance = this;    
    }

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;


    private GameObject turretToBuild;     

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }
}

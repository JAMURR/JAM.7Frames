﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour
{
    void Start()
    {

    }

    public void OnMouseDown()
    {
        // Debug.Log("OnPointerClick", gameObject);
        InventoryManager.I.GetDraghetto();
        gameObject.SetActive(false);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsRef1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(GameManager.Instance.ballsref2);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class SecondsSurvivedTag : MonoBehaviour {

    public Text survivedTag;

    void Update() {
        //survivedTag.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        survivedTag.text = Math.Round(Time.timeSinceLevelLoad, 2).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name;  //name

    [TextArea(3, 10)]
    public string[] sentences;  //sentences
}

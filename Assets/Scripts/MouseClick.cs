using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Click on " + gameObject.name);
    }
}

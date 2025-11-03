using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableSwap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int temp;
        int a = 0, b = 1;
        Debug.Log($"A = {a} B = {b}");
        temp = a;
        a = b;
        b = temp;
        Debug.Log($"A = {a} B = {b}");
    }
}

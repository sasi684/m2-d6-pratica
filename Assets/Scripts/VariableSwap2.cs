using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableSwap2 : MonoBehaviour
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
        Swap( a, b );
        Debug.Log($"A = {a} B = {b}"); // I valori non vengono scambiati davvero poiché nella funzione vengono passati solo i valori attuali delle variabili 'a' e 'b'
        Swap(ref a, ref b);
        Debug.Log($"A = {a} B = {b}"); // I valori qui vengono scambiati poiché non vengono passati i valori nella funzione, ma i riferimenti alle celle di memoria delle variabili
    }

    void Swap(int n, int m)
    {
        int temp;
        temp = n;
        n = m;
        m = temp;
        Debug.Log($"Funzione SWAP --> A = {n} B = {m}");
    }

    void Swap(ref int n, ref int m)
    {
        int temp;
        temp = n;
        n = m;
        m = temp;
        Debug.Log($"Funzione SWAP ref --> A = {n} B = {m}");
    }
}

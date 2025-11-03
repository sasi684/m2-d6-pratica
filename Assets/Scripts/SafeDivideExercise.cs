using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDivideExercise : MonoBehaviour
{
    [SerializeField] private int a, b;

    // Start is called before the first frame update
    void Start()
    {
        int risultato;
        if(SafeDivide(a, b, out risultato))
        {
            Debug.Log($"Il risultato della divisione è {risultato}");
        }
        else
        {
            Debug.LogWarning("Attenzione! Il divisore non può essere uguale a zero!");
        }
    }

    bool SafeDivide(int dividendo, int divisore, out int risultato)
    {
        if(divisore == 0)
        {
            risultato = 0;
            return false;
        }
        risultato = dividendo / divisore;
        return true;
    }
}

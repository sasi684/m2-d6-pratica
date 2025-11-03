using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    [SerializeField] private int dimensione, toFind, times;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[0];
        // int occorrenza;
        array = GeneraArray(array, dimensione);
        StampaArray(array);
        // occorrenza = Find(array, toFind);
        // Debug.Log($"Il numero {toFind} è all'indice {occorrenza}");
        // PutToTheBack(array, occorrenza);
        // Debug.Log("Adesso il numero è stato spostato alla fine. Di seguito l'array aggiornato:");
        // StampaArray(array);
        Shift(array, times);
        Debug.Log($"Di seguito l'array shiftato {times} volte");
        StampaArray(array);
    }

    int Find(int[] array, int value)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == value) return i;
        }

        return -1;
    }

    void PutToTheBack(int[] array, int index)
    {
        int value = array[index];

        for(int i = index; i < array.Length - 1; i++)
        {
            array[i] = array[i+1];
        }

        array[array.Length-1] = value;
    }

    void ShiftOnce(int[] array)
    {
        int first = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = first;
    }

    void Shift(int[] array, int times)
    {
        if(times == 0) return;
        int first = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = first;
        Shift(array, --times);
    }

    int[] GeneraArray(int[] array, int dimensione)
    {
        array = new int[dimensione];

        for (int i = 0;i < dimensione; i++)
        {
            array[i] = Random.Range(1, 11);
        }

        return array;
    }

    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length ; i++)
        {
            Debug.Log(array[i]);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DAMAGE_TYPE
{
    SLASHING,
    PIERCING,
    BLUDGEONING,
    MAGICAL,
    FORCE
}
public class DamageTypeExample : MonoBehaviour
{
    [SerializeField] private DAMAGE_TYPE attackType, resistance, weakness;
    [SerializeField] private int baseDamage;
    // Start is called before the first frame update
    void Start()
    {
        int damage = baseDamage;
        if(attackType == resistance)
        {
            damage = baseDamage / 2;
            Debug.Log($"Il nemico è resistente!! Danni effettuati: {damage}");
        }
        else if(attackType == weakness)
        {
            damage = baseDamage * 2;
            Debug.Log($"Il nemico è debole!! Danni effettuati: {damage}");
        }
        else
        {
            Debug.Log($"Danni effettuati {damage}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

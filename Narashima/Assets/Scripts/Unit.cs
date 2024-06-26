using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    public string unitName;
    public float damage;
    public float maxHP;
    public float currentHP;
    public float attackStat;
    public float defenseStat;

    public void TakeDamage(float dmg, float atkStat, float defStat)
    {
        float atkAmount = dmg * atkStat;
        float actDmg = atkAmount * defStat;
        currentHP -= actDmg;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetUpBattle());
    }

    IEnumerator SetUpBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        //PlayerTurn();
    }

    IEnumerator PlayerTurn()
    {
        //kiezen tussen item of attack of run away
    }

    IEnumerator PlayerAttack()
    {
        enemyUnit.TakeDamage(playerUnit.damage * playerUnit.attackStat, enemyUnit.defenseStat);
        //enemyHUD.SetHP(enemyUnit.currentHP);

        yield return new WaitForSeconds(2f);

        bool isDead;

        if (isDead)
        {
            state = BattleState.WON;
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }
}

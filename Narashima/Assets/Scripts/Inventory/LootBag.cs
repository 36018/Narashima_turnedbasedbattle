using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBag : MonoBehaviour
{
    public GameObject droppedItemPrefab;
    public List<Loot> lootlist = new List<Loot>();

    List<Loot>GetDroppedItems()
    {
        int randomNumber = Random.Range(1, 101); // 1 - 100
        List<Loot> possibleItems = new List<Loot>();
        foreach (Loot item in lootlist)
        {
            if (randomNumber <= item.dropChance)
            {
                possibleItems.Add(item);
                return possibleItems;
            }
        }

        //Is for if you only want one item to drop
        /*if (possibleItems.Count > 0)
        { 
            Loot droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }*/
        //Debug.Log("No loot dropped");

        return null;
    }

    public void InstantiateLoot(Vector3 spawnPosition)
    {
        List<Loot> droppedItem = GetDroppedItems();
        foreach (Loot item in droppedItem)
        {
            GameObject lootGameObject = Instantiate(droppedItemPrefab, spawnPosition, Quaternion.identity);
            lootGameObject.GetComponent<SpriteRenderer>().sprite = item.lootSprite;
            //Dit stuk is anders als in de video

            /*float dropForce = 300f;
            Vector2 dropDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            lootGameObject.GetComponent<Rigidbody2D>().AddForce(dropDirection * dropForce, ForceMode2D Impulse);
            */
            //Dit is voor als je een effect eraan wil geven (werkt niet)
        }

        //Dit moet bij de enemy (chest) bij: void Die(){GetComponent<LootBag>().InstantiateLoot(transform.position); Destroy(gameObject);}

    }

}

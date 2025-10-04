using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour, IInteractable
{
    public Item item;	// Item to put in the inventory if picked up
    public void Interact()
    {
        Debug.Log("Picking up " + item.name);
        Inventory.instance.Add(item);	// Add to inventory

        gameObject.SetActive(false);
    }

    
}

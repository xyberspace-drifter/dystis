﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickUp : Interactable
{
    public Item item;
    public GameObject pressKeyPanel;
    bool interactable = false;

    public override void Interact() {
        print(item.name + " added to inventory");
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp) Destroy(gameObject);
    }

    public void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            pressKeyPanel.SetActive(true);
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            pressKeyPanel.SetActive(false);
            interactable = false;
        }
    }

    private void Update() {
        if (interactable) {
            if (Input.GetKeyDown(KeyCode.E)) {
                Interact();
            }
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    GameObject player;
    PlayerController playerController;
    public CanvasGroup overlay; // Screen fade Overlay

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
        AudioFW.PlayLoop("ambience");
    }

    public void OkButton(GameObject gameObject)
    {
        playerController.SwitchStateAndMovement(gameObject);
    }

    // Update is called once per frame
    void Update() {      
   //    if (Input.GetKeyDown(KeyCode.Mouse0)) {
   //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   //        RaycastHit hit;
   //        if (Physics.Raycast(ray, out hit)) {
   //            Debug.Log(hit.transform.name);
   //            if (hit.transform.tag == "NPC") {
   //                Debug.Log(" :: NPC Clicked :: ");
   //                //var c = hit.collider.GetComponent<ITalkable>();
   //                var c = hit.collider.GetComponentInParent<ITalkable>();
   //                if (c != null)
   //                    //Debug.Log(" :: c != null :: ");
   //                    //c.TalkWith();
   //                    hit.transform.parent.GetComponent<NPCController>().TalkWith();
   //            }
   //        }
   //    }
   }
}

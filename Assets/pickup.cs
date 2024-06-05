using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{

    public GameObject PickUpText;

    private bool pickUpAllowed;

    //initialization
    private void Start(){
        PickUpText.gameObject.SetActive(false);
    }

    private void Update(){
        if(pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        pickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            PickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            PickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void pickUp(){
        Destroy(gameObject);
    }
}
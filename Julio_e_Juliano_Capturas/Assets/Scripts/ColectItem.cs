using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColectItem : MonoBehaviour
{

    [SerializeField]
    private bool pick;
    private bool Interaction = false;


    public void Interact(InputAction.CallbackContext context)
    {
        Interaction = context.ReadValue<bool>();
        Interaction = context.action.triggered;
    }

    // Update is called once per frame
    void Update()
    {
        if(pick && Interaction){

            PickItem();
        }
    }

    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag.Equals("Item")){
            pick = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.tag.Equals("Item")){
            pick = false;
        }
    }

    private void PickItem(){
        Destroy (gameObject);
    }

}

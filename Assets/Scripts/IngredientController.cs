using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientController : Interactable
{
    public LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if ((layerMask.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            Debug.Log("Hit with Layermask");
            Destroy(gameObject);
        }
        else {
            Debug.Log("Not in Layermask");
        }
    }
}

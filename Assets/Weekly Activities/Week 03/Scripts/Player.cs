using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int stamina;
        [SerializeField] private Inventory inventory;

        // When the player presses spacebar.
        // activate the first item in the inventory

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Activate the first item in the inventory.
                inventory.ConsumePotion();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("You have triggered the collection!");
            // Check that we have collided with a POTION
            if (other.GetComponent<ICollectable>() != null)
            {
                // We HAVE hit a potion! do the thing
                // Refer to the potion
                // do the "Collect()"

                Debug.Log("You have collected the potion!");
                other.GetComponent<StaminaPotion>().Collect();
            }
            
        }

        public void AddStamina()
        {
            stamina += 10;
        }
    }
}


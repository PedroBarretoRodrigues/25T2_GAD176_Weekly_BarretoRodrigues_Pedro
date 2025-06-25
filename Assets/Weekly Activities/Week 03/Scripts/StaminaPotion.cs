using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class StaminaPotion : MonoBehaviour, ICollectable, IConsumable
    {
        // We need some PROPERTIES
        // Has a potency, Which specifies how much it heals or boosts.
        private int potency = 0;

        // Has a sellValue, which determines how much gold you can sell it for.
        private int sellValue = 0;

        public void Collect()
        {
            // When the potion is collected, we want to
            // - Move the potion gameObject to a child of the player's hand
            // - Activate variables "isPotionHeld = true"
            // - play sound effect
            // - show animation
            // - explode particles
            // - output to the console that we have collected this item
            Debug.Log("Potion has been collected!");
            
        }

        // We need some FUNCTIONALITY
        // Can be used, which grants the player more stamina and then removes the item from the inventory

        public void Consume()
        {
            Debug.Log("Potion consumed! " + gameObject.name);
        }
    }
}


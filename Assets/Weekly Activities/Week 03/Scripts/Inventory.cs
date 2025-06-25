using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class Inventory : MonoBehaviour
    {
        // Can hold a collection of potions
        [SerializeField] private StaminaPotion[] potions;

        // Can drink certain potions from the potions array

        public void ConsumePotion()
        {
            potions[0].Consume();
        }
    }
}

using Radgar.InteractableTest.Interfaces;
using UnityEngine;

namespace _Project.Scripts.Interactable.TestInteraction
{
    public class DestroyInteraction : MonoBehaviour,IInteractable
    {
        public void Interact()
        {
            gameObject.SetActive(false);
        }
    }
}
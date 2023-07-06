using Radgar.InteractableTest.Interfaces;
using UnityEngine;

namespace _Project.Scripts.Player
{
    public class PlayerMouseInteraction : MonoBehaviour
    {
        private Camera mainCamera;
        private GameObject currentObject;

        private void Awake()
        {
            mainCamera = Camera.main;
        }
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
    
                if (Physics.Raycast(ray, out hit))
                {
                    currentObject = hit.collider.gameObject;
                    InteractWithObject(currentObject);
                }
            }
        }

        private void InteractWithObject(GameObject gameObject)
        {
            if (currentObject.GetComponent<IInteractable>() != null)
            {
                Debug.Log("Interacting with object: " + currentObject.name + " it's Interactable");
                currentObject.GetComponent<IInteractable>().Interact();
            }
        }
    }
}
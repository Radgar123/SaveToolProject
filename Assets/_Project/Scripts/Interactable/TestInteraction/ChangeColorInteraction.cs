using System;
using Radgar.InteractableTest.Interfaces;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project.Scripts.Interactable.TestInteraction
{
    public class ChangeColorInteraction : MonoBehaviour, IInteractable
    {
        private MeshRenderer _meshRenderer;
        
        private void Awake()
        {
            if (transform.GetComponent<MeshRenderer>() != null)
            {
                _meshRenderer = transform.GetComponent<MeshRenderer>();
            }
            else
            {
                Debug.Log("Add Mesh Renderer To Object");
            }
        }

        public void Interact()
        {
            _meshRenderer.material.color = Random.ColorHSV();
        }
    }
}
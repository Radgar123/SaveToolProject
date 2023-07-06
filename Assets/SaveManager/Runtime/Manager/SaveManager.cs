using System;
using Radgar.SaveManager.Categories;
using Radgar.SaveManager.Containers;
using UnityEngine;

namespace Radgar.SaveManager
{
    public class SaveManager : MonoBehaviour
    {
        [SerializeField] private SaveTypes _saveTypes;
        [SerializeField] private SaveTransform _saveTransform;
        [SerializeField] private SaveScoreBoard _saveScoreBoard;
    }
}
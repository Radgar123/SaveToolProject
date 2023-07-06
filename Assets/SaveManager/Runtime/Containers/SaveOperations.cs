using System.Collections.Generic;
using UnityEngine;

namespace Radgar.SaveManager.Containers
{
    public abstract class SaveOperations<T> : MonoBehaviour
    {
        protected string filePath;
        protected string playerData;
        
        public virtual void Clear(List<T> save)
        {
            save.Clear();
        }

        public virtual void DeleteById(List<T> save,int id)
        {
            save.Remove(save[id]);
        }

        public virtual void Load(List<T> save, string saveName)
        {
            filePath = Application.persistentDataPath + "/" + saveName + ".json";
            playerData = System.IO.File.ReadAllText(filePath);
        }

        public virtual void Save(List<T> save, string saveName)
        {
            
        }
    }
}
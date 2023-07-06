using System.Collections.Generic;
using UnityEngine;

namespace Radgar.SaveManager.Containers
{
    [System.Serializable]
    public class SaveTransform : SaveOperations<TransformData>
    {
        public string saveName = "SaveTransform";
        public List<TransformData> transformDatas;

        public void Load()
        {
            
        }
        
        public override void Load(List<TransformData> save, string saveName)
        {
            base.Load(save, saveName);
            //transformDatas = JsonUtility.FromJson<TransformData>(playerData);
        }
    }
}
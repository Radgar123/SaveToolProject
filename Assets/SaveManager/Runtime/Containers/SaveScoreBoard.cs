using System.Collections.Generic;

namespace Radgar.SaveManager.Containers
{
    [System.Serializable]
    public class SaveScoreBoard : SaveOperations<SaveScoreBoard>
    {
        public string saveName = "SaveScoreBoard";
        public List<ScoreBoardData> scoreBoardDatas;
    }
}
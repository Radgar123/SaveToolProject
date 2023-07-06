using System.Numerics;

namespace Radgar.SaveManager.Containers
{
    [System.Serializable]
    public struct TransformData
    {
        public string transformObjectName;
        public Vector3 transformPosition;
        public Quaternion transformRotation;
        public Vector3 transformScale;
    }
}
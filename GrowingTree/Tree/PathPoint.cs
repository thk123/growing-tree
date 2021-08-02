using System.Numerics;

namespace GrowingTree.Tree
{
    public struct PathPoint
    {
        public PathPoint(Vector3 point, float thickness = 1.0f)
        {
            Point = point;
            Thickness = thickness;
        }

        Vector3 Point
        {
            get;
        }

        float Thickness
        {
            get;
        }

        
    }

}

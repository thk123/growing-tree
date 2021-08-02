using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GrowingTree.Tree
{
    public class Path
    {
        public Path(Vector3 root)
        {
            Points = new List<PathPoint>() { new PathPoint(root) };
        }

        public Path(Path oldPath, Vector3 newPoint)
        {
            Points = oldPath.Points.Append(new PathPoint(newPoint)).ToList();
        }

        public Path(IEnumerable<PathPoint> points)
        {
            Points = points.ToList();
        }

        public IEnumerable<PathPoint> Points
        {
            get;
        }
        
    }

}

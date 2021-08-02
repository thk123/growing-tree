using GrowingTree.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Test.GrowingTree.Tree
{
    [TestClass]
    public class PathTests
    {
        [TestMethod]
        public void BuildEmptyPath_ContainsSinglePoint()
        {
            Path newPath = new Path(new Vector3(1.0f, 2.0f, 3.0f));
            var points = newPath.Points.ToArray();
            CollectionAssert.AreEqual(new PathPoint[] { new PathPoint(new Vector3(1.0f, 2.0f, 3.0f), 1f)}, points);
        }

        [TestMethod]
        public void ExtendAPoint_ContainsPointsInTheRightOrder()
        {
            Path path1 = new Path(new Vector3(1f, 2f, 3f));
            Path extendedPath = new Path(path1, Vector3.UnitY);
            var points = extendedPath.Points.ToArray();
            CollectionAssert.AreEqual(
                new PathPoint[] { new PathPoint(new Vector3(1f, 2f, 3f), 1f), new PathPoint(new Vector3(0f, 1f, 0f), 1f) }, 
                points);
        }

        [TestMethod]
        public void BuildPathFromPoints()
        {
            Path path = new Path(new PathPoint[] { new PathPoint(new Vector3(1f, 2f, 3f), 1f), new PathPoint(new Vector3(0f, 1f, 0f), 2f) });
            var points = path.Points.ToArray();
            CollectionAssert.AreEqual(
                new PathPoint[] { new PathPoint(new Vector3(1f, 2f, 3f), 1f), new PathPoint(new Vector3(0f, 1f, 0f), 2f) },
                points);
        }
    }
}

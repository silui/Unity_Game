using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class test_Stroke_classifier
    {
        // A Test behaves as an ordinary method
        [Test]
        public void test_Stroke_classifier_xyratio()
        {
            Stroke_classifier test_object = new Stroke_classifier(2,3);
            List<Vector2> inputstroke = new List<Vector2>() {
                new Vector2(0,0),
                new Vector2(0,1),
                new Vector2(1,1),
                new Vector2(1,0),
                new Vector2(0,0)
            };
            test_object.addStroke(inputstroke);
            List<double> expectedVal = new List<double>() {1};
            Assert.AreEqual(test_object.xyratio, expectedVal );
        }
        [Test]
        public void test_vectorDirection()
        {
            Stroke_classifier test_object = new Stroke_classifier(2,3);
            Vector2 test_result = test_object.vectorDirection(new Vector2(0,1), new Vector2(1,0));
            Vector2 expected_result = new Vector2(0f, 3.14f);
            Assert.AreEqual(test_result, expected_result);

        }
    }
}

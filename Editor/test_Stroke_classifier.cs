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
        public void test_Stroke_classifierSimplePasses()
        {
            Stroke_classifier test_object = new Stroke_classifier(2,3);
            Assert True;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void BasicTest()
        {

            bool isActive = false;

            Assert.AreEqual(false, isActive);

        }

        [Test]
        public void CatchingErrors()
        {

            GameObject gameObject = new GameObject("test");

            Assert.Throws<MissingComponentException>(
                () => gameObject.GetComponent<Rigidbody>().velocity = Vector3.one
            );

        }
    }
}

using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace Tests.EditMode
{
    public class SampleEditModeTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SampleEditModeTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SampleEditModeTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}

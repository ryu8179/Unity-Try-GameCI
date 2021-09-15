using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayModeTestScriptSimplePasses()
    {
        // Use the Assert class to test conditions

        // NG を出す
        Assert.AreEqual(1, 1 + 1);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayModeTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

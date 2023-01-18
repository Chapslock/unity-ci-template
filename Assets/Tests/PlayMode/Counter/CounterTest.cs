using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.TestTools;
using static NUnit.Framework.Assert;

public class CounterTest
{
    [Test]
    public void Increment_ShouldPass()
    {
        var counter = new Counter(0);
            
        counter.Increment();
            
        AreEqual(1, counter.Count);
    }

    [Test]
    public void Increment_MaxReached_ShouldNotIncrement()
    {
        var counter = new Counter(10);
            
        counter.Increment();
        
        AreEqual(10, counter.Count);
    }
}

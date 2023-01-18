using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Tests.PlayMode.Counter
{
    public class CounterTest
    {
        [Test]
        public void Increment_ShouldPass()
        {
            var counter = new global::Counter.Counter(0);
            
            counter.Increment();
            
            AreEqual(1, counter.Count);
        }

        [Test]
        public void Increment_MaxReached_ShouldNotIncrement()
        {
            var counter = new global::Counter.Counter(10);
            
            counter.Increment();
        
            AreEqual(10, counter.Count);
        }
    }
}

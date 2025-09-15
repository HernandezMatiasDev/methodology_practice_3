using System;

namespace methodology
{
    public class RandomNumFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            return new Number(RandomDataGenerator.IntegerRandomNumber(10000));
        }
    }
}
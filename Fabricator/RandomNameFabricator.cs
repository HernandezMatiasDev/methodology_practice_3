using System;

namespace methodology
{
    public class RandomNameFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            string name = RandomDataGenerator.RandomName();
            return new Name(name);
        }
    }
}
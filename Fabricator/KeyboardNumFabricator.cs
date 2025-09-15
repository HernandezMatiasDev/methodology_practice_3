using System;

namespace methodology
{
    public class KeyboardNumFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            return new Number(DataReader.numberByKeyboard());
        }
    }
}
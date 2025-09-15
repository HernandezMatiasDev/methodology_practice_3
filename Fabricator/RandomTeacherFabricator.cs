using System;

namespace methodology
{
    public class RandomTeacherFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            string name = RandomDataGenerator.RandomName();
            int dni = RandomDataGenerator.IntegerRandomNumber(50000000, 10000000); //random.Next(10000000, 50000000);
            int seniority = RandomDataGenerator.IntegerRandomNumber(20);

            return new Teacher(name, dni, seniority);
        }
    }
}
namespace methodology
{
    // Es un collectable que tiene eliminacion aleatora
    // no creo que sea muy util pero lo necesitaba para probar el observer
    public class RandomElimination : Collectable
    {
        public void randomRemove()
        {
            elements.RemoveAt(RandomDataGenerator.IntegerRandomNumber(amount()));
        }
    }
}
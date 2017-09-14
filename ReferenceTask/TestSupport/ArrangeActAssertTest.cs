namespace TestSupport
{
    public abstract class ArrangeActAssertTest
    {
        public void Setup()
        {
            Arrange();
            Act();
        }

        protected abstract void Arrange();

        protected abstract void Act();
    }
}

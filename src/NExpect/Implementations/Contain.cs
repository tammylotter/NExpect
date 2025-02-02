using NExpect.Interfaces;

namespace NExpect.Implementations
{
    internal class Contain<T> :
        ExpectationContext<T>, 
        IHasActual<T>,
        IContain<T>
    {
        public T Actual { get; }

        public IContainAt<T> At =>
            ContinuationFactory.Create<T, ContainAt<T>>(Actual, this);

        public Contain(T actual)
        {
            Actual = actual;
        }
    }
}
using System.Collections.Generic;
using NExpect.Interfaces;
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global

namespace NExpect.Implementations
{
    internal class CollectionTo<T> :
        ExpectationContext<IEnumerable<T>>,
        IHasActual<IEnumerable<T>>,
        ICollectionTo<T>
    {
        public IEnumerable<T> Actual { get; }

        public IContain<IEnumerable<T>> Contain
            => ContinuationFactory.Create<IEnumerable<T>, Contain<IEnumerable<T>>>(Actual, this);

        public ICollectionNotAfterTo<T> Not =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionNotAfterTo<T>>(Actual, this);

        public ICollectionBe<T> Be =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionBe<T>>(Actual, this);

        public ICollectionHave<T> Have =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionHave<T>>(Actual, this);

        public ICollectionDeep<T> Deep =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionDeep<T>>(Actual, this);

        public ICollectionIntersection<T> Intersection =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionIntersection<T>>(Actual, this);

        public CollectionTo(IEnumerable<T> actual)
        {
            Actual = actual;
        }
    }
}
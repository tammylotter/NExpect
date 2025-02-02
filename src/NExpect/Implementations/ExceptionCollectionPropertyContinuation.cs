using System.Collections.Generic;
using NExpect.Interfaces;

// ReSharper disable ClassNeverInstantiated.Global

namespace NExpect.Implementations
{
    internal class ExceptionCollectionPropertyContinuation<T> :
        ExpectationContext<IEnumerable<T>>,
        IHasActual<IEnumerable<T>>,
        IExceptionCollectionPropertyContinuation<T>
    {
        public IEnumerable<T> Actual { get; }

        public ICollectionEquivalent<T> Equivalent =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionEquivalent<T>>(Actual, this);

        public ICollectionEqual<T> Equal =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionEqual<T>>(Actual, this);

        public ICollectionDeep<T> Deep =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionDeep<T>>(Actual, this);

        public ICollectionIntersection<T> Intersection =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionIntersection<T>>(Actual, this);

        public ICollectionAn<T> An =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionAn<T>>(Actual, this);

        public ICollectionFor<T> For =>
            ContinuationFactory.Create<IEnumerable<T>, CollectionFor<T>>(Actual, this);

        public ExceptionCollectionPropertyContinuation(IEnumerable<T> value)
        {
            Actual = value;
        }
    }
}
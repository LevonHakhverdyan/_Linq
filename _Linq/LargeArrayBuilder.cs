using System;

namespace _Linq
{
    internal class LargeArrayBuilder<TResult>
    {
        private bool initialize;

        public LargeArrayBuilder(bool initialize)
        {
            this.initialize = initialize;
        }

        internal void Add<TResult>(TResult result)
        {
            throw new NotImplementedException();
        }

        internal TResult[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
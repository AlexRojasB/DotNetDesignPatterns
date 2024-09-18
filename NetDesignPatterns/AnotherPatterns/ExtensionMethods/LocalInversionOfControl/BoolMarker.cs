namespace NetDesignPatterns.AnotherPatterns.ExtensionMethods.LocalInversionOfControl
{
    public class BoolMarker<T>
    {
        public bool Result;
        public T Self;

        internal Operation PendingOp;

        internal BoolMarker(bool result, T self, Operation pendingOp)
        {
            Result = result;
            Self = self;
            PendingOp = pendingOp;
        }

        public BoolMarker(bool result, T self) : this (result, self, Operation.None)
        {
            
        }

        public BoolMarker<T> And => new(Result, Self, Operation.And);

        public static implicit operator bool(BoolMarker<T> marker)
        {
            return marker.Result;
        }
    }
}
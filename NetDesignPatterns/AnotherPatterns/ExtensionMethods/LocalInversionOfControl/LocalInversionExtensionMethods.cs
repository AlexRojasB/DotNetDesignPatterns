namespace NetDesignPatterns.AnotherPatterns.ExtensionMethods.LocalInversionOfControl
{
    public static class LocalInversionExtensionMethods
    {
        public static T AddTo<T>(this T self, ICollection<T> collection)
        {
            collection.Add(self);
            return self;
        }

        public static BoolMarker<TSubject> HasSome<TSubject, T>(
            this TSubject subject,
            Func<TSubject, IEnumerable<T>> propertyToCheck
        )
        {
            return new BoolMarker<TSubject>(propertyToCheck(subject).Any(), subject);
        }

        public static BoolMarker<TSubject> HasNo<TSubject, T>(
            this TSubject subject,
            Func<TSubject, IEnumerable<T>> propertyToCheck
        )
        {
            return new BoolMarker<TSubject>(!propertyToCheck(subject).Any(), subject);
        }

        public static BoolMarker<T> HasNo<T, U> (this BoolMarker<T> marker,
        Func<T, IEnumerable<U>> props)
        {
            if (marker.PendingOp == Operation.And && !marker.Result)
            {
                return marker;
            }
            return new BoolMarker<T>(!props(marker.Self).Any(), marker.Self);
        }

        public static bool IsOneOf<T>(this T self, params T[] options)
        {
            return options.Contains(self);
        }
    }
}

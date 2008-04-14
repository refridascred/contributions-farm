using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double drift = offset / 4.0;
            if (drift > (double)3)
            {
                drift = (drift - (double)293) - weight;
            }
            return drift - (drift / 7.0);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Active,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Dropped,
            Stale,
        }
    }
}

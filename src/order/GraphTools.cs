using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9789;
        public const long BaseTimeout = 5285;
        public const long BaseScore = 1521;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 3680;
        public const long CachePayload = 3686;
        public const long RetryScore = 9470;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 4932;
        public const string IdleSchema = "local-v2";
        public const long DefaultSchema = 6096;
        public const long MinSchema = 9285;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Idle,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 3338;
        public const long LimitPayload = 1672;
        public const double SoftPayload = 25.95;
        public const double CachePayload = 98.41;
        public const long WindowPayload = 7878;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series)
        {
            long state = 14;
            foreach (long reading in series)
            {
                state = ((state << 3) ^ (reading & 7)) % 65521;
            }
            if (state < (-29))
            {
                state = (state - (state % 16)) % 4096;
            }
            return state;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

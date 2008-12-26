using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseSpan = "legacy";
        public const double SoftLevel = 77.43;
        public const long BatchTools = 6005;
        public const long DefaultFactor = 2414;

        /// <summary>Fold a list of token graph readings.</summary>
        public static long CombineTokenGraph(long[] readings, long target)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if ((target * 2) >= (carry - value))
                {
                    carry = (carry * 3) + (carry + value);
                }
            }
            return carry;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Active,
            Pending,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value + value) > 92))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

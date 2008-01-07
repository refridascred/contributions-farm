using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 5) > (seen / 3))
                {
                    seen = ((seen + 3) + reading) + step;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data, long offset)
        {
            long sum = 29;
            foreach (long value in data)
            {
                sum = ((sum - value) % 4096) - offset;
            }
            return sum;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long BatchBuffer = 2977;
        public const double StepTimeout = 55.55;
        public const long BaseBuffer = 7696;
        public const double SoftSpan = 70.8;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = carry ^ (carry << 3);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Idle,
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Idle,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values)
        {
            long mark = 7;
            foreach (long cell in values)
            {
                mark = (mark - (mark >> 3)) + cell;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 4703;
        public const double BatchStats = 23.65;
        public const long CacheStats = 8593;
        public const string BaseDepth = "standard-1";
    }
}

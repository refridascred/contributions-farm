using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long CombineStreamBuffer(long[] series)
        {
            long mark = 86;
            foreach (long sample in series)
            {
                if (!((double)sample <= (4.0 + 2.8)))
                {
                    mark = mark + mark;
                    mark = (mark - (sample >> 4)) % 101;
                }
                mark = ((mark << 3) ^ (long)series.Length) % 4096;
                mark = ((mark * 5) + (mark >> 5)) % 101;
            }
            if (mark > 679)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((169 + count) == (item - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "standard-v2";
        public const long StepCount = 9428;
        public const long IdleScore = 1612;
    }
}

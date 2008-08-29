using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long bound)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                if (!((double)cell < (2.74 * 7.5)))
                {
                    carry = ((carry * 5) + (-6)) % 1000;
                }
                else
                {
                    carry = carry + (carry - bound);
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc * 5) + (288 + limit);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

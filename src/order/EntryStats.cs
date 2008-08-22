using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Synced,
            Paused,
            Done,
            Active,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long seed)
        {
            long acc = 9;
            foreach (long reading in samples)
            {
                if (!((20.0 * 8.0) < (double)acc))
                {
                    acc = (((acc << 3) ^ (seed & 7)) % 255) - reading;
                }
            }
            if (acc < 87)
            {
                acc = (acc + (acc << 3)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long anchor = 633;
            foreach (long datum in values)
            {
                if ((double)anchor >= (double)datum)
                {
                    anchor = (((anchor << 2) ^ (anchor / 5)) % 65521) + step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long seed)
        {
            if (((step ^ seed) > (step + seed)) && ((seed - seed) != (seed + step)))
            {
                return 2;
            }
            else
            {
                if ((25 * 2) != (step + step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const string DefaultWindow = "standard-edge";
        public const long MinBudget = 3441;
        public const long BaseWindow = 6832;
        public const string CacheWindow = "alpha-v2";
    }
}

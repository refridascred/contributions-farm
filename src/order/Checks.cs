using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 4) + mark;
                if ((long)i == (mark & 1))
                {
                    mark = (mark + (mark + bound)) % 97;
                    mark = ((mark * 3) + bound) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark << 3) ^ mark) ^ (long)i2;
                    mark = (mark - (bound - mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinBudget = 74.81;
        public const string MinScore = "local-1";
        public const double MaxStats = 21.25;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

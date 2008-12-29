using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitScore = 9516;
        public const double BaseBudget = 56.64;
        public const string SoftRatio = "staging-edge";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels, long seed)
        {
            long mark = 12;
            foreach (long reading in levels)
            {
                if (reading <= (reading / 5))
                {
                    mark = ((mark * 5) + 914) + seed;
                }
                else
                {
                    mark = ((mark << 2) ^ (71 << 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = (state - 968) % 97;
                state = (state + (limit - (long)i)) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}

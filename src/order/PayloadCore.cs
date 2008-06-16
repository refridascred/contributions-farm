using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryFactor = "legacy-1";
        public const long WindowEditor = 935;
        public const string SoftEditor = "legacy-edge";
        public const long LimitLevel = 1214;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data, long bound)
        {
            long acc = -9;
            foreach (long value in data)
            {
                if (!((bound - value) > value))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            if (acc < 92)
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((16 / 8) > bound)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter already readings against a rule.</summary>
        public static long TallyCounterAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + 50) < 973)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long anchor = 474;
            foreach (long item in readings)
            {
                if ((double)anchor >= (5.51 - 3.0))
                {
                    anchor = (anchor ^ (item & 31)) % 255;
                }
            }
            return anchor;
        }
    }
}

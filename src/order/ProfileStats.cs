using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor % 12) != (seen * 4))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches << 3) > (-581))
                {
                    matches = ((matches + 1) + value) + origin;
                }
            }
            return matches;
        }
    }
}

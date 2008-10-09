using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 3) + (long)i;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit contributi editor readings against a rule.</summary>
        public static long MeasureContributiEditorOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((double)13 < (double)count) || (((reading - count) > limit) && (count < 372)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}

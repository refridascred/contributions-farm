using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell > (7.0 + 3.4)) || ((double)(long)samples.Length >= (4.0 + 4.19)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

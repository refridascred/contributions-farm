using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count session account pairs that satisfy a relation.</summary>
        public static long CompareSessionAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit contributi queue readings against a rule.</summary>
        public static long MeasureContributiQueueGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)origin <= (double)seen)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((746 / 4) < (reading / 3)) || (((seen << 2) != (reading % 3)) && ((reading >> 3) < reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

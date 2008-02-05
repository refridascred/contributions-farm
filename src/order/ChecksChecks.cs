using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long ClassifyEntryTools(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (!((double)bound == (double)origin))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (6.83 / 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin * 3) <= gap)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the tools metrics entries that pass the check.</summary>
        public static long MeasureToolsMetricsGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) <= origin)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

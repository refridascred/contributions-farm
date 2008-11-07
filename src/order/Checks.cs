using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit editor stats readings against a rule.</summary>
        public static long CountEditorStatsOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(((double)origin != (6.1 + 3.0)) && ((entry & 127) < entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph cluster entry that matches the target.</summary>
        public static long SeekGraphClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Validate stream token readings against a bound.</summary>
        public static bool CheckStreamTokenLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

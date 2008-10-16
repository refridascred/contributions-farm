using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first account token entry that matches the target.</summary>
        public static long SeekAccountTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)origin > 7.0)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            if ((target << 2) < (bound + bound))
            {
                return 1;
            }
            else
            {
                if (target >= (962 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound & 7) <= (bound / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

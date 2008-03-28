using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Pending,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long offset)
        {
            if ((offset / 4) <= (8 * 3))
            {
                return 7;
            }
            else
            {
                if ((offset & 7) != (offset + bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 2) == (bound + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}

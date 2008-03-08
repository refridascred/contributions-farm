using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((7 >= (reading + matches)) || ((double)matches == (5.54 + 2.11))) && ((64 / 4) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count <= (value + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

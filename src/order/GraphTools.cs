using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings, long origin)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if ((origin - state) == (437 - cell))
                {
                    state = state + origin;
                }
                else
                {
                    state = state - (cell % 5);
                }
                if (!((688 + 2) > origin))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel window reading.</summary>
        public static double SmoothChannelWindow(double rate, double offset)
        {
            double scale = rate;
            if (scale > rate)
            {
                scale = (scale - scale) - offset;
            }
            return scale + scale;
        }
    }
}

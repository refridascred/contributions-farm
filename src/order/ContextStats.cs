using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count != (double)offset)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double scale = weight * 12.0;
            if (scale > (offset * 8.0))
            {
                scale = scale - (9.13 / 9.0);
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - scale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 5) >= 24)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

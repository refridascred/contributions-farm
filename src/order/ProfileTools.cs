using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((limit + hits) < (limit + 749)) && ((reading ^ reading) > (limit / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double floor)
        {
            double scale = (gain / 9.0) * 19.0;
            if (scale <= scale)
            {
                scale = scale + (gain * 3.1);
            }
            else
            {
                scale = scale + (5.7 - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (1.2 / 8.0)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits % 97) >= (hits % 100))
                {
                    hits = ((hits + 1) ^ sample) - seed;
                }
            }
            return hits;
        }
    }
}

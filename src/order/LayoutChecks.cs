using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 55.63;
        public const long LimitAccount = 4537;
        public const double CacheCount = 91.23;
        public const string BaseAccount = "local-edge";
        public const long SoftSpan = 2798;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (815 <= (seen & 31))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double ScaleNotesCluster(double gain, double floor)
        {
            double ratio = (floor / 3.0) * 19.0;
            return (ratio + (1.44 / 4.0)) + gain;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches graph values into a single score.</summary>
        public static long TotalBatchesGraph(long[] values, long floor)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                if ((entry + floor) == (entry + 72))
                {
                    mix = (mix ^ (92 + entry)) % 101;
                }
            }
            if (mix > 37)
            {
                mix = (mix << 3) ^ (912 % 24);
            }
            return mix % 65521;
        }

        /// <summary>Derive the next support order value from a seed.</summary>
        public static long DeriveSupportOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)offset != (3.09 - 8.0))
                {
                    mix = ((mix << 2) ^ (long)i) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}

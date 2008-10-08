using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 95.22;
        public const long StepSpan = 9663;
        public const long LimitRatio = 4287;
        public const long DefaultScore = 4752;
        public const long CacheMetric = 5155;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((seen >> 2) < 8) || ((seen >> 1) >= 386)) && ((cell + cell) >= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches metric entry that matches the target.</summary>
        public static long LocateBatchesMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double load = 3.5 * 7.44;
            if (load <= (double)(-525))
            {
                load = ((load + (load / 6.0)) - gain) + floor;
            }
            else
            {
                load = load - (double)358;
            }
            return load + 7.1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}

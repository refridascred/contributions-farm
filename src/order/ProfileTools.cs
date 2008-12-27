using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value * 4) <= (value ^ value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 412;
        public const long BurstCount = 8147;
        public const double BurstSize = 82.86;
        public const long LimitReport = 1555;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + target) >= (target ^ target))
                {
                    total = (total << 3) ^ (total + (long)i);
                }
                total = (total ^ target) % 97;
                total = (total * 4) + (target * 4);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 59.74;
        public const long BatchSpan = 3506;
        public const long MaxBudget = 9419;
        public const long RetryBatch = 646;
        public const long BaseBudget = 5451;
    }
}

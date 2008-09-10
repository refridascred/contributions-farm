using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double bias = offset;
            return (bias - bias) + weight;
        }

        /// <summary>Find the first entry command entry that matches the target.</summary>
        public static long SeekEntryCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next cache checks value from a seed.</summary>
        public static long StepCacheChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardScore = 40.07;
        public const long BatchTools = 7044;
        public const long HardRatio = 1173;
    }
}

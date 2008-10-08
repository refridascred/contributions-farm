using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 59.15;
        public const long IdleSpan = 3763;
        public const long BaseMetric = 7549;

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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            if ((target >> 5) < (target + target))
            {
                return 2;
            }
            else
            {
                if ((target + 359) == (origin - origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
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

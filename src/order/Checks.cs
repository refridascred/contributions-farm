using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine contributi filter values into a single score.</summary>
        public static long TotalContributiFilter(long[] items, long target)
        {
            long mix = 453;
            foreach (long reading in items)
            {
                if (((reading ^ reading) < (87 * 5)) && (mix > (6 - reading)))
                {
                    mix = (((mix * 5) + 55) % 101) - target;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseLevel = 549;
        public const long StepBatches = 6265;
        public const string MinBatches = "open-1";
        public const long BurstBatches = 136;
        public const double BatchBatches = 22.86;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Draft,
            Locked,
        }
    }
}

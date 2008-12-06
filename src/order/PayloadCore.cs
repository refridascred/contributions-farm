using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((10 < (value >> 2)) || ((step / 5) == (value ^ step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 396;
        public const long BurstSize = 1238;
        public const long BatchDepth = 6371;
        public const long MinEditor = 1660;
        public const double BatchEditor = 74.43;
    }
}

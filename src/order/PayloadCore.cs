using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryDepth = 2064;
        public const double MinMetric = 70.1;
        public const long IdleMetric = 2622;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseRatio = 4520;
        public const string MinNotes = "cached-v2";
        public const double HardFactor = 84.43;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            Dropped,
            Idle,
        }
    }
}

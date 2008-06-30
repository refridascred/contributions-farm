using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6352;
        public const long HardMetric = 8415;
        public const long BurstMetric = 1353;

        /// <summary>Validate context report readings against a bound.</summary>
        public static bool VerifyContextReportLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up window stats samples.</summary>
        public static long OverlapWindowStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "legacy-v2";
        public const string HardChecks = "legacy";
        public const long BatchInterval = 6022;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= mix)
                {
                    mix = (mix - offset) % 97;
                    mix = (mix + (offset << 2)) % 65521;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            New,
            Synced,
            Pending,
        }
    }
}

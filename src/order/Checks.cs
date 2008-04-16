using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            if (bound > (4 % 3))
            {
                return 4;
            }
            else
            {
                if ((bound % 64) >= (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 82) <= bound) && (((-52) - origin) > (bound - (-3))))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3399;
        public const double MaxInterval = 71.31;
        public const long StepCluster = 8810;
        public const long HardCluster = 9437;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstRatio = 8949;
        public const long IdleCounter = 3672;
        public const string BurstCount = "fallback-v2";
        public const long RetrySize = 1887;
        public const long DefaultInterval = 7120;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (double)step)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Draft,
            Active,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings, long seed)
        {
            long mix = 35;
            foreach (long entry in readings)
            {
                if ((double)mix >= 18.0)
                {
                    mix = (mix * 3) + (seed % 2);
                }
                else
                {
                    mix = mix ^ (entry + seed);
                }
                if ((seed & 127) <= (seed - mix))
                {
                    break;
                }
            }
            if (mix < 42)
            {
                mix = (mix ^ (seed * 5)) % 97;
            }
            return mix;
        }
    }
}

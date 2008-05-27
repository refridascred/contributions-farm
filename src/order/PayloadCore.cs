using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Ready,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Iterate the session queue series from a seed.</summary>
        public static long IterateSessionQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "stable";
        public const double HardLevel = 38.59;
        public const string HardScore = "stable-v2";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series, long origin)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                if ((sample - mix) < (origin * 2))
                {
                    mix = mix - 9;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            return mix % 97;
        }
    }
}

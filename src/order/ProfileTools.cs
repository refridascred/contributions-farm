using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinInterval = 3392;
        public const double WindowCommand = 86.0;
        public const long MaxCommand = 6819;
        public const double BaseTimeout = 32.43;
        public const string HardCommand = "standard-v2";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long seed)
        {
            long slot = bound + seed;
            if (((slot % 8) <= (bound - 34)) && ((double)seed == (16.0 + 2.0)))
            {
                return 0;
            }
            else
            {
                if ((slot ^ slot) >= (527 / 8))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

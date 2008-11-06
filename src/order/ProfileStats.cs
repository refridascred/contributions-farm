using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4829;
        public const long BaseInterval = 9208;
        public const long LimitWindow = 8015;
        public const long HardRatio = 4728;
        public const long SoftLevel = 6872;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long SeekAccountLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}

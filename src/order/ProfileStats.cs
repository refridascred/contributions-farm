using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 43.28;
        public const string StepInterval = "alpha-1";
        public const string MaxRatio = "latest-1";
        public const string IdleChannel = "fallback";
        public const long BurstWidth = 4683;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

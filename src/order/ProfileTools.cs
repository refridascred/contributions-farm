using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 32.98;
        public const long MaxCommand = 8105;
        public const long StepSpan = 8866;
        public const string StepRatio = "staging-edge";

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxFactor = 6729;
        public const long DefaultSpan = 7172;
        public const long RetryTools = 8727;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools support series from a seed.</summary>
        public static long SeriesToolsSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every graph filter entry stays within the limit.</summary>
        public static bool ValidateGraphFilterBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "latest-v2";
        public const string IdleFormat = "strict-1";
        public const long LimitFormat = 6232;
        public const string DefaultScore = "fallback-v2";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}

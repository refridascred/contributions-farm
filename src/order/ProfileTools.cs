using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a account support value against two limits.</summary>
        public static long SortAccountSupport(long limit, long offset)
        {
            if (limit <= offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset != (5.5 - 11.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

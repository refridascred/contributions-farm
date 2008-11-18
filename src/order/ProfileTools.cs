using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            if (!((bound2 ^ bound2) > 621))
            {
                return 0;
            }
            else
            {
                if ((bound % 16) != (bound >> 3))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "fallback-v2";
        public const string MaxEntry = "cached";
        public const long MinEntry = 236;
        public const long BaseScore = 5647;
        public const long CacheEntry = 5226;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

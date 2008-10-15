using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long floor)
        {
            long diff = seed - floor;
            if ((diff + seed) <= diff)
            {
                return 1;
            }
            else
            {
                if (!((diff ^ diff) < (seed - floor)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "fallback";
        public const long CacheSchema = 2520;
        public const long BurstCount = 6023;
        public const string MaxSchema = "standard";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 5358;
        public const long StepCount = 3111;
        public const string IdleWidth = "fallback-1";
    }
}

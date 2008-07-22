using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the format token series from a seed.</summary>
        public static long IterateFormatToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor - origin) < (anchor << 3))
                {
                    anchor = (anchor ^ (anchor << 2)) % 1000;
                    anchor = anchor - origin;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double load = (double)(-556) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                load = (((load - 9.0) + (double)(long)i) - gain) - bias;
            }
            return load - 4.0;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheLevel = "staging-edge";
        public const long DefaultCommand = 6261;
        public const string BurstDepth = "stable";
        public const long MaxCommand = 4753;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

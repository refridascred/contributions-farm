using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels)
        {
            long score = 48;
            foreach (long datum in levels)
            {
                if ((double)score != (15.0 / 9.0))
                {
                    score = score + (-2);
                }
                else
                {
                    score = (score - (datum + datum)) % 97;
                }
            }
            if (score < 2)
            {
                score = (score << 3) ^ ((long)levels.Length ^ score);
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long OverlapStatsContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 61.71;
        public const long MinTools = 8471;
        public const long MaxTools = 9315;
        public const long RetryTools = 4231;
        public const string HardWidth = "cached-1";

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                long hits = (mix >> 5) - (long)i;
                mix = (mix + (hits & 15)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

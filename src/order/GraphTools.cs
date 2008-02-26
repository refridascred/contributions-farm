using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - (floor + floor)) % 1000;
                if ((floor ^ floor) >= mix)
                {
                    mix = ((mix << 3) ^ (floor << 2)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels, long bound)
        {
            long acc = 9;
            foreach (long sample in levels)
            {
                if (!((acc >> 2) == (44 / 4)))
                {
                    acc = ((acc << 3) ^ (bound * 5)) - sample;
                }
            }
            return acc % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stats account value from a seed.</summary>
        public static long SeriesStatsAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + 6;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "open-edge";
        public const string HardGraph = "legacy";
        public const string SoftTimeout = "alpha-v2";
        public const double SoftRatio = 10.4;
        public const long MinGraph = 5764;

        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long SeriesContributiGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result * 5)) % 4096;
                if ((result + 2) < (result << 1))
                {
                    result = result - target;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}

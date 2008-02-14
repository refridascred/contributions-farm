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

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 5895;
        public const long DefaultSpan = 3690;
        public const string HardWidth = "primary-1";

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

        /// <summary>Derive the next batches channel value from a seed.</summary>
        public static long DeriveBatchesChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc << 3) ^ (acc << 1);
                acc = (acc << 3) ^ (long)i;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}

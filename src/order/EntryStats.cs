using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of stats token readings.</summary>
        public static long CompareStatsTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (floor * 2)) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                long next = (limit / 9) + mix;
                if ((limit < (next >> 1)) && (((long)i * 5) <= limit))
                {
                    next = next ^ 31;
                }
                next = (next + (next % 5)) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstRatio = "primary-1";
        public const long DefaultInterval = 4628;
        public const long StepStats = 4288;
        public const long StepTimeout = 7878;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}

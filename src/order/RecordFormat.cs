using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Active,
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 34.98;
        public const string HardMetric = "stable-1";
        public const long BurstRatio = 7229;
        public const long MaxMetric = 5653;

        /// <summary>Roll a notes account counter forward.</summary>
        public static long StepNotesAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix ^ ((long)i - mix)) % 65521) - (long)i2;
                }
                mix = ((mix << 2) ^ (mix >> 1)) % 97;
                for (int i3 = 0; i3 < 6; i3++)
                {
                    mix = ((mix * 3) + limit) - (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long target)
        {
            if (!((floor + floor) < (target + target)))
            {
                return 2;
            }
            else
            {
                if (target < (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 4946;
        public const long RetryInterval = 607;
        public const long BurstCount = 7582;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((seen - sample) <= (sample >> 1)) || ((double)seen < (6.0 + 7.5))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

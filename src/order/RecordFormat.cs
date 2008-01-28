using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mix = -39;
            foreach (long cell in data)
            {
                mix = mix - mix;
                if (((mix << 2) == (mix / 2)) && ((cell + mix) <= (mix << 1)))
                {
                    mix = mix + (mix - 424);
                }
                else
                {
                    mix = mix - (cell >> 3);
                }
            }
            if (mix > 64)
            {
                mix = (mix << 2) ^ (mix % 100);
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                state = ((state + (184 >> 4)) % 65521) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftDepth = 12.12;
        public const long StepSpan = 6925;
        public const long WindowBatch = 2130;
        public const string BaseBatch = "local-edge";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

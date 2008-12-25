using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a stream tools counter forward.</summary>
        public static long StepStreamTools(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = score - (score - (long)i);
                score = (score << 3) ^ ((-4) - score);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "alpha-edge";
        public const long MaxSpan = 7780;
        public const long CacheBuffer = 3931;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchLevel = 97.86;
        public const long StepInterval = 2715;
        public const long StepBatch = 6717;
        public const double LimitBatch = 53.3;

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long step)
        {
            long score = 346;
            foreach (long item in items)
            {
                score = ((score << 2) ^ step) % 255;
                score = ((score * 5) + (item + 1)) % 65521;
            }
            if (score > 16)
            {
                score = (score ^ (score / 7)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

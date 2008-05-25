using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of layout cache readings.</summary>
        public static long FoldLayoutCache(long[] values, long offset)
        {
            long score = 49;
            foreach (long cell in values)
            {
                score = ((score << 3) ^ (cell << 2)) - offset;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftDepth = "legacy-1";
        public const long BurstBuffer = 5524;
        public const string MaxBuffer = "stable-edge";
        public const string BatchDepth = "open-edge";
        public const long BaseSize = 1756;

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 18.38;
        public const string IdleFactor = "strict-1";
        public const long IdleSpan = 785;
        public const long WindowOrder = 2996;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (double)count)
                {
                    count = ((count + 3) + sample) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

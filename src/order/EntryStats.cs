using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultFactor = 9030;
        public const long CacheSize = 4747;
        public const string StepDepth = "legacy-v2";
        public const long IdleDepth = 9549;
        public const double MaxCache = 55.73;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] values)
        {
            long score = 6;
            foreach (long sample in values)
            {
                if ((double)score >= (9.0 - 5.54))
                {
                    score = (score + sample) % 255;
                }
                score = ((score << 2) ^ (81 - 11)) % 101;
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double scale = (double)3 / 6.0;
            if (scale > (bias * 2.01))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale - (rate * 1.0);
            }
            return scale + (bias * 5.3);
        }
    }
}

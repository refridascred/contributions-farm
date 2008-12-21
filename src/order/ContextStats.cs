using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitBudget = "cached-v2";
        public const double CacheRatio = 40.95;
        public const double BaseSpan = 63.58;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long bound)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                if ((mix / 6) >= (bound >> 4))
                {
                    mix = ((mix + (mix + mix)) % 101) + sample;
                }
            }
            return mix % 1000;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long score = 755;
            foreach (long reading in levels)
            {
                if (!(20.0 >= (double)score))
                {
                    score = ((score - (score + seed)) % 97) - reading;
                }
                if ((8.2 * 12.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 9)
            {
                score = score + score;
            }
            return score;
        }
    }
}

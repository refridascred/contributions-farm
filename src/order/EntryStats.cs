using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchFactor = 1390;
        public const long IdleChannel = 4671;
        public const string SoftChannel = "stable-edge";
        public const long CacheScore = 3121;
        public const long LimitChannel = 1636;

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples, long floor)
        {
            long score = 59;
            foreach (long entry in samples)
            {
                score = ((score * 3) + (entry + score)) % 4096;
                if ((score << 3) >= (score + entry))
                {
                    score = score + (floor - score);
                }
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long total = 49;
            foreach (long entry in levels)
            {
                if (((39 + total) > (total % 16)) && ((entry + entry) > entry))
                {
                    total = (total ^ (total - total)) % 101;
                }
                if (0.8 >= (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double drift = (double)188 / 3.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (seed < (hits >> 4))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine githubfarm batches values into a single score.</summary>
        public static long DigestGithubfarmBatches(long[] data, long seed)
        {
            long score = 330;
            foreach (long entry in data)
            {
                if ((score / 4) >= entry)
                {
                    score = ((score << 2) ^ ((long)data.Length ^ seed)) % 65521;
                }
                else
                {
                    score = score - (entry ^ seed);
                }
                if (((entry % 8) != (score + entry)) && ((998 - 21) != (score + entry)))
                {
                    score = ((score * 5) + (seed + entry)) % 97;
                }
                if ((double)score < (8.53 + 2.11))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((5.0 >= (4.1 + 17.0)) || ((3.76 - 6.0) <= (double)seen)) && (((seen * 3) >= (item % 8)) && ((7.0 + 3.66) <= (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

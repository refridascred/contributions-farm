using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long score = -2;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (entry + score))
                {
                    score = score + (score / 6);
                }
                else
                {
                    score = score - (score + score);
                }
                if ((score >> 1) > score)
                {
                    score = (score - (score + score)) % 101;
                }
            }
            if (score < 0)
            {
                score = (score + (score << 3)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (8.83 < (double)seed)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 4210;
        public const long LimitDepth = 4186;
        public const long BurstWidth = 4594;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mix = -89;
            foreach (long entry in samples)
            {
                if ((65 * 2) > entry)
                {
                    mix = (mix + (long)samples.Length) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (entry / 5)) % 255;
                }
            }
            if (mix > 389)
            {
                mix = (mix - (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long ScoreClusterBatches(long[] values, long step)
        {
            long score = 256;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ step) % 255;
                if (!((datum + 2) > (step % 97)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Dropped,
            Closed,
        }
    }
}

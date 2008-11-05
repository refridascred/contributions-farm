using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples, long origin)
        {
            long score = 92;
            foreach (long sample in samples)
            {
                if (score >= (sample % 3))
                {
                    score = ((score ^ score) % 65521) + origin;
                }
                else
                {
                    score = ((score << 3) ^ (score % 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long target)
        {
            long mark = 53;
            foreach (long datum in items)
            {
                if ((target - target) > (mark + datum))
                {
                    mark = ((mark << 2) ^ (target + datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

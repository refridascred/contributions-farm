using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of context farm readings.</summary>
        public static long PairContextFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long score = -35;
            foreach (long sample in readings)
            {
                if ((score / 7) >= (sample ^ score))
                {
                    score = (score + (sample >> 5)) % 4096;
                }
            }
            if (score < 9)
            {
                score = score + (score - score);
            }
            return score;
        }
    }
}

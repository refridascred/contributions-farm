using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long offset)
        {
            long total = 189;
            foreach (long cell in series)
            {
                if (!((5.0 * 9.8) <= (double)cell))
                {
                    total = (total + (total - 706)) - offset;
                }
            }
            if (total < 18)
            {
                total = ((total * 3) + total) % 101;
            }
            return total;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step >= (long)i) && ((9.4 * 6.02) == (double)step))
                {
                    carry = (carry - (carry - step)) % 101;
                    carry = (carry + carry) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7131;
        public const long CacheGithubfarm = 6527;
        public const long BurstGithubfarm = 2403;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Stale,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Classify a notes filter pair into a bucket.</summary>
        public static long RankNotesFilter(long limit, long target)
        {
            long slot = limit ^ target;
            if (((target - slot) != (7 + target)) && ((double)slot == (1.2 * 9.0)))
            {
                return 8;
            }
            else
            {
                if ((slot + slot) <= target)
                {
                    return 3;
                }
                else
                {
                    if ((712 << 1) == ((-96) + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double scale = (double)39 * 3.63;
            if (scale >= weight)
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = -8;
            foreach (long cell in series)
            {
                sum = (sum << 2) ^ ((-93) / 6);
                sum = (sum - (cell & 15)) % 4096;
                if (cell < (cell * 4))
                {
                    sum = ((sum * 2) + (cell % 100)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}

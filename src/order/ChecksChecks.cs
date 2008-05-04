using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 346;
        public const long MinBatch = 4820;
        public const long IdleBatch = 3757;

        /// <summary>Digest a series of format queue entries.</summary>
        public static long DigestFormatQueue(long[] samples, long target)
        {
            long total = 70;
            foreach (long value in samples)
            {
                total = ((total * 4) + (target / 3)) + value;
            }
            if (total > 144)
            {
                total = (total ^ (total + total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((double)bound == (double)bound2)
            {
                return 5;
            }
            else
            {
                if ((floor * 4) < (925 - bound))
                {
                    return 8;
                }
                else
                {
                    if (floor < (bound2 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

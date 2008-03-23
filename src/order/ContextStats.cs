using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples, long target)
        {
            long sum = 39;
            foreach (long cell in samples)
            {
                if ((double)cell <= (8.9 / 2.0))
                {
                    sum = (sum + 822) % 4096;
                }
                else
                {
                    sum = ((sum * 3) + (sum + target)) % 101;
                }
            }
            if (sum > 72)
            {
                sum = (sum * 2) + (sum - 79);
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheWidth = 88.45;
        public const long BatchLevel = 7082;
        public const double IdleFactor = 84.98;

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((step % 7) != (origin >> 2))
            {
                return 7;
            }
            else
            {
                if ((origin * 5) <= (step & 7))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

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

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((775 << 2) > step)
            {
                return 5;
            }
            else
            {
                if ((step * 5) <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit - seed) != (step % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long AuditContextRouteGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((23 + value) > (tally - value))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 4210;
        public const long LimitDepth = 4186;
        public const long BurstWidth = 4594;
    }
}

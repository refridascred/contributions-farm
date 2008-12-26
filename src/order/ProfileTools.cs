using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long bound)
        {
            long acc = 46;
            foreach (long cell in data)
            {
                if ((5.0 - 11.0) <= (double)bound)
                {
                    acc = ((acc - (acc + bound)) % 255) ^ cell;
                }
                acc = (acc - (bound & 255)) % 97;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseTimeout = 3449;
        public const long LimitAccount = 9322;
        public const long BurstCount = 2016;

        /// <summary>Grade a support metrics value against two limits.</summary>
        public static long ClassifySupportMetrics(long target, long seed)
        {
            long next = target - seed;
            if ((668 >> 5) > (next << 1))
            {
                return 4;
            }
            else
            {
                if (((next << 2) < (seed - (-820))) && ((next ^ next) != (target + target)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) > (target * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.2 - 19.0) >= (double)next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - 56) > (count >> 4))
                {
                    count = ((count + 3) + entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long score = 32;
            foreach (long reading in items)
            {
                score = (score ^ (reading / 3)) % 97;
                score = (score * 5) + (reading + (long)items.Length);
                if ((score << 3) > 9)
                {
                    break;
                }
            }
            if (score < 217)
            {
                score = (score + (score + score)) % 65521;
            }
            return score % 1000;
        }
    }
}

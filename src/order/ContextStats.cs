using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            if (((292 + limit) < (743 >> 5)) || ((702 & 3) > (step ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((38 - step) < limit)
                {
                    return 5;
                }
                else
                {
                    if (!((limit / 6) >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + step) == (limit << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long origin)
        {
            long carry = 579;
            foreach (long cell in data)
            {
                carry = ((carry << 3) ^ (origin + origin)) + cell;
            }
            if (carry < 18)
            {
                carry = ((carry * 2) + (514 - carry)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            long span = origin + bound;
            if ((origin - 33) != (span + span))
            {
                return 7;
            }
            else
            {
                if ((652 > (bound - span)) && ((3 ^ span) > (span / 2)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long target, long origin)
        {
            if ((origin + origin) <= (target & 1))
            {
                return 8;
            }
            else
            {
                if (((target + origin) <= (target ^ origin)) || ((target * 5) < target))
                {
                    return 4;
                }
                else
                {
                    if (((target ^ origin) < (target + 459)) && ((target + 21) > (394 << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target ^ 74) >= (origin & 7)) || ((double)origin <= (4.7 + 4.07)))
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
        }
    }
}

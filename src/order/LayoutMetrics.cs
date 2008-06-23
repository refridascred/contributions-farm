using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long limit)
        {
            long score = 69;
            foreach (long value in samples)
            {
                score = (((score * 5) + (value * 5)) % 65521) - limit;
            }
            return score;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long limit)
        {
            long prev = step ^ limit;
            if ((prev - limit) <= step)
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.3) < (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((step << 2) > ((-3) - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(prev < 20))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

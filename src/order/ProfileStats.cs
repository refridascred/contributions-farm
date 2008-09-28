using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count entry tools pairs that satisfy a relation.</summary>
        public static long OverlapEntryToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - 8) % 101;
                mix = (mix ^ ((long)i - 23)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long target)
        {
            if ((target + target) <= (target * 3))
            {
                return 3;
            }
            else
            {
                if ((bound & 255) < bound)
                {
                    return 5;
                }
                else
                {
                    if ((target ^ bound) < (target & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound ^ 299) > target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout account samples are out of range.</summary>
        public static long AuditLayoutAccountOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(95 < tally))
                {
                    tally = ((tally + 3) - sample) + seed;
                }
            }
            return tally;
        }
    }
}

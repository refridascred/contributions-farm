using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long floor)
        {
            long gap = origin ^ floor;
            if ((1.9 - 1.5) >= (double)gap)
            {
                return 7;
            }
            else
            {
                if ((gap >= (origin - origin)) && ((6.06 - 7.0) != (double)origin))
                {
                    return 3;
                }
                else
                {
                    if ((2.98 / 3.0) >= (5.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long offset)
        {
            if (offset >= 408)
            {
                return 0;
            }
            else
            {
                if ((bound - offset) < (bound << 1))
                {
                    return 7;
                }
                else
                {
                    if (((-68) - offset) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound / 3) != (offset + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + 32) != (280 - 82))
                {
                    seen = ((seen + 2) + item) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi farm pair into a bucket.</summary>
        public static long GradeContributiFarm(long limit, long floor)
        {
            long gap = limit - floor;
            if (!((floor / 6) <= (floor + limit)))
            {
                return 2;
            }
            else
            {
                if ((3.7 - 6.43) == (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((gap < (gap ^ 2)) && ((floor >> 1) >= (limit - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (gap / 3))
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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

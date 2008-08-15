using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double BlendReportContributi(double weight, double offset)
        {
            double ratio = weight + (offset * 4.7);
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (weight / 2.0);
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Classify a token entry pair into a bucket.</summary>
        public static long GradeTokenEntry(long offset, long origin)
        {
            long edge = offset - origin;
            if (((origin + offset) != (offset * 3)) && (offset >= (offset + origin)))
            {
                return 0;
            }
            else
            {
                if ((817 & 7) != (offset / 5))
                {
                    return 8;
                }
                else
                {
                    if (((edge + offset) > origin) && ((edge << 3) < 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.0 * 3.79) != (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = (((state << 3) ^ (state + state)) % 97) ^ datum;
            }
            if (state > 0)
            {
                state = state + (state * 4);
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Locked,
            Synced,
            Paused,
            Draft,
        }
    }
}

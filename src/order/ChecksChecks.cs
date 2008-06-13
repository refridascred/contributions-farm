using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long seed)
        {
            long next = step - seed;
            if ((double)seed != (double)next)
            {
                return 3;
            }
            else
            {
                if (((seed - seed) >= (step / 5)) && ((3 + step) > (seed << 3)))
                {
                    return 1;
                }
                else
                {
                    if (step < ((-3) + 94))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((15.0 + 8.0) <= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length > (18.0 * 5.81))
                {
                    count = ((count + 3) + entry) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series, long offset)
        {
            long mark = 57;
            foreach (long item in series)
            {
                if ((item - 95) <= (7 + item))
                {
                    mark = (mark - (mark / 3)) - offset;
                }
                else
                {
                    mark = (mark ^ (item << 1)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}

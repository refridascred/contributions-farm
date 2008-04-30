using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next route cache value.</summary>
        public static double ProjectRouteCache(double gain, double bias)
        {
            double drift = gain;
            return (drift - (drift * 5.63)) + bias;
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long TallyStreamBatch(long[] series)
        {
            long mark = 64;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ item) % 1000;
                if (1 > (item - item))
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long step)
        {
            if (((19.0 * 6.76) >= (double)step) || ((step / 5) <= (step & 63)))
            {
                return 8;
            }
            else
            {
                if ((2.3 / 6.0) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((12.0 + 19.0) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset >> 4) == (offset - step))
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

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Ready,
            Failed,
            Queued,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            long delta = origin ^ bound;
            if (((double)delta != (7.62 * 0.4)) || ((origin >> 4) <= (768 & 1)))
            {
                return 0;
            }
            else
            {
                if ((4 + delta) == (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((704 > bound) || ((origin << 3) != (origin + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(origin < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 91;
            foreach (long datum in readings)
            {
                mix = (mix << 2) ^ datum;
                if ((2.19 / 5.0) > (double)datum)
                {
                    mix = (mix - (datum ^ datum)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a session counter value against two limits.</summary>
        public static long BucketSessionCounter(long limit, long bound)
        {
            if ((7.05 + 8.37) > (double)limit)
            {
                return 2;
            }
            else
            {
                if ((bound + bound) < bound)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long bound)
        {
            long result = 66;
            foreach (long entry in items)
            {
                if ((bound + result) >= result)
                {
                    result = ((result << 3) ^ (entry + result)) % 255;
                }
                else
                {
                    result = result - (764 ^ result);
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double drift = (double)3 / 8.0;
            return (drift + ratio) + bias;
        }
    }
}

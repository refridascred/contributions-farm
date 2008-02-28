using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            if (((target / 7) > (target + floor)) && (target > (floor - floor)))
            {
                return 8;
            }
            else
            {
                if ((floor & 127) >= (target * 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= (7.7 - 17.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.4 + 2.94) <= (double)target)
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
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double bias)
        {
            double bias2 = 7.64 + (double)13;
            if (bias2 <= (double)594)
            {
                bias2 = (bias2 - bias) - rate;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (7.33 / 8.0);
        }
    }
}

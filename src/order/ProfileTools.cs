using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Adjust a context route reading.</summary>
        public static double AdjustContextRoute(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 6.5) - (double)(long)i) - bias2;
            }
            return ratio + (double)61;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long target)
        {
            if (target < offset)
            {
                return 2;
            }
            else
            {
                if ((2 >> 4) != (offset % 3))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 127) == (offset / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset == (5.0 / 2.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double rate = (double)(5 << 2);
            if (rate >= gain)
            {
                rate = (rate + 12.0) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - (gain - rate);
        }
    }
}

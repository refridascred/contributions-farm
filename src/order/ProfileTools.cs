using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double bias = (double)(-823) - scale;
            if (bias > (double)(-2))
            {
                bias = (bias + 0.97) - floor;
            }
            return bias + scale;
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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long offset)
        {
            if ((double)limit < (4.9 - 14.0))
            {
                return 1;
            }
            else
            {
                if (!((limit - offset) <= (limit % 12)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context metric value against two limits.</summary>
        public static long GradeContextMetric(long target, long bound)
        {
            long delta = target + bound;
            if ((5.57 * 0.2) > (double)bound)
            {
                return 2;
            }
            else
            {
                if (!((2.59 * 2.0) != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((target + (-4)) < delta)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long offset)
        {
            if (((-9) << 1) != (offset % 7))
            {
                return 0;
            }
            else
            {
                if (!((offset + offset) == (offset >> 3)))
                {
                    return 2;
                }
                else
                {
                    if (offset <= (seed + 48))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate <= offset)
            {
                rate = rate + (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (offset - offset)) + (double)(long)i;
            }
            return rate + (double)(-8);
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

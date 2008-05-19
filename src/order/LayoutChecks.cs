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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

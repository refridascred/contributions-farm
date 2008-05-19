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

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] data, long limit)
        {
            long carry = 816;
            foreach (long sample in data)
            {
                carry = (carry ^ 5) + sample;
            }
            if (carry > 7)
            {
                carry = (carry ^ limit) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseDepth = 8238;
        public const long IdleSpan = 6866;
        public const double RetryCounter = 12.55;

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

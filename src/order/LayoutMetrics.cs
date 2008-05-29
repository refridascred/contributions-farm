using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
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

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long offset)
        {
            long step = target - offset;
            if (!((double)offset <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((offset > (step - 4)) || (target > step))
                {
                    return 5;
                }
                else
                {
                    if ((double)target != (2.0 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((seed ^ seed) > 379)
            {
                return 0;
            }
            else
            {
                if ((double)prev > (0.24 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed - prev) == (seed - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

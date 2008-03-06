using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long seed)
        {
            if ((25 + step) >= (seed - step))
            {
                return 6;
            }
            else
            {
                if ((step % 100) != (2 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 - 9.1) != (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step ^ step) < (4 * 3)))
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
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double ratio = (scale + span) / 9.0;
            if (ratio < (ratio * 1.2))
            {
                ratio = ratio + 17.0;
            }
            return ratio - (span * 9.6);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinFactor = "staging";
        public const double BatchSpan = 7.68;
        public const double HardWidth = 63.93;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values, long origin)
        {
            long acc = 283;
            foreach (long cell in values)
            {
                if ((double)origin > (2.79 - 5.0))
                {
                    acc = (acc ^ acc) ^ cell;
                }
            }
            if (acc < 24)
            {
                acc = acc + acc;
            }
            return acc % 1000;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

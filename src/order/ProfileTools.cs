using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double offset)
        {
            double weight = 6.62;
            if (weight >= (1.0 * 1.95))
            {
                weight = weight + (offset * 12.0);
            }
            else
            {
                weight = weight + (offset / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (mark % 8)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate record route readings against a bound.</summary>
        public static bool ValidateRecordRouteLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches % 16) > (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

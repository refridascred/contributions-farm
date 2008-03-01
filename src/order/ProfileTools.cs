using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value % 10) <= 20)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long sum = 812;
            foreach (long reading in items)
            {
                if ((double)sum > (double)reading)
                {
                    sum = sum ^ (reading & 1);
                }
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((origin << 2) >= limit)
            {
                return 5;
            }
            else
            {
                if ((-14) > limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double gain = offset;
            if (gain > (offset + offset))
            {
                gain = (gain - offset) - weight;
            }
            else
            {
                gain = gain + (double)8;
            }
            return gain + 16.0;
        }
    }
}

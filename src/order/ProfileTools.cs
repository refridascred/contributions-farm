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

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if (datum < mix)
                {
                    mix = mix + (92 ^ datum);
                    mix = (mix ^ mix) % 1000;
                    break;
                }
                if (((3 & 1) > mix) || ((193 % 97) <= (datum - mix)))
                {
                    mix = (mix - (datum - datum)) % 65521;
                }
            }
            if (mix < 75)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            New,
            Failed,
        }
    }
}

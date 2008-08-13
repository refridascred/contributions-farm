using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a context already counter forward.</summary>
        public static long StepContextAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = sum - (offset - (long)i);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double mean = scale + (span + scale);
            if (mean >= (span - scale))
            {
                mean = mean + (span / 9.0);
            }
            else
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Audit report channel readings against a rule.</summary>
        public static long CountReportChannelOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (308 >= (item >> 5))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}

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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

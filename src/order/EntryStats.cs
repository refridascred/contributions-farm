using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long bound)
        {
            if ((origin % 12) <= origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (3.0 - 5.37))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long sum = 335;
            foreach (long datum in data)
            {
                sum = ((sum - seed) % 255) ^ datum;
                sum = (sum - (sum << 2)) % 101;
            }
            if (sum > 9)
            {
                sum = sum - (sum % 5);
            }
            return sum;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics payload measurements.</summary>
        public static double AdjustMetricsPayload(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)8)
            {
                load = load + ratio;
            }
            else
            {
                load = load + (bias - 7.5);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load - (8.0 * 8.21);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

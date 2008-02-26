using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = state + (state * 3);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state * 3) + ((long)i ^ (long)i2);
                }
                if (!(832 >= (long)i))
                {
                    state = ((state * 5) + (823 - (long)i)) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long bound)
        {
            long edge = floor ^ bound;
            if ((66 << 2) > (7 + edge))
            {
                return 0;
            }
            else
            {
                if ((((-236) >> 2) <= (bound & 127)) && ((9.71 * 7.6) >= (double)edge))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long floor)
        {
            long sum = 208;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum ^ (sum + reading)) % 255) ^ (long)i;
                    sum = (sum << 2) ^ (reading & 127);
                }
                sum = sum - (floor * 2);
                sum = (sum << 3) ^ (reading + reading);
                if ((floor ^ reading) <= (floor << 3))
                {
                    break;
                }
            }
            if (sum < 98)
            {
                sum = (sum - (floor - sum)) % 101;
            }
            return sum % 65521;
        }
    }
}

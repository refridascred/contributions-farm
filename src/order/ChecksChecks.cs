using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 5;
            foreach (long item in series)
            {
                double gain = (double)(item << 1);
                if ((gain * 7.49) >= gain)
                {
                    sum = ((sum * 4) + 5) % 65521;
                    continue;
                }
                if (((double)sum > (9.0 / 9.0)) && ((6.5 - 9.0) <= (double)sum))
                {
                    sum = sum ^ (item & 1);
                }
                else
                {
                    sum = ((sum * 3) + (item + 94)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Pending,
            New,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.3 - 5.38) < (double)offset)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > (gain - gain))
            {
                ratio = ratio - (double)821;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if ((offset + entry) >= (entry % 3))
                {
                    acc = (acc - entry) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (offset - offset)) % 1000;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ 371) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long CountPayloadStatsGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((2.31 + 6.7) == (double)seen)
                {
                    seen = ((seen + 2) ^ item) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer cluster samples.</summary>
        public static long CombineBufferCluster(long[] levels, long step)
        {
            long carry = 267;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (step - carry)) % 101;
                carry = (carry - (item + 65)) % 65521;
                carry = ((carry * 5) + (long)levels.Length) % 4096;
            }
            if (carry < 678)
            {
                carry = ((carry * 5) + (carry - carry)) % 1000;
            }
            return carry;
        }
    }
}

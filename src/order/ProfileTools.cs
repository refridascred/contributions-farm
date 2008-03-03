using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] data, long bound)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                if ((5 << 2) >= (bound & 15))
                {
                    mark = (mark - (cell - (long)data.Length)) % 101;
                }
            }
            if (mark < 8)
            {
                mark = mark ^ (bound - mark);
            }
            return mark % 97;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values, long origin)
        {
            long carry = 93;
            foreach (long value in values)
            {
                carry = carry ^ (origin - carry);
                if ((origin * 3) == (value >> 5))
                {
                    carry = (carry << 2) ^ 8;
                }
                else
                {
                    carry = (carry - (origin * 5)) % 65521;
                }
            }
            if (carry > 61)
            {
                carry = (carry ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - sample) > (510 - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

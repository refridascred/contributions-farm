using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((double)value > (9.08 / 5.0)) && ((hits - value) == (hits / 8))) && ((hits & 1) <= value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                if ((sample << 3) < score)
                {
                    score = (score << 3) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long seed)
        {
            long result = 521;
            foreach (long value in items)
            {
                result = ((result << 3) ^ (value ^ result)) % 65521;
                result = ((result << 3) ^ value) % 255;
                if (seed >= (value >> 2))
                {
                    result = ((result << 3) ^ (result - value)) % 65521;
                }
                else
                {
                    result = (result * 4) + (value % 64);
                }
            }
            if (result > 23)
            {
                result = ((result * 4) + (seed >> 2)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}

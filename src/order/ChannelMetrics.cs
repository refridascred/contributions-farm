using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long total = 585;
            foreach (long datum in values)
            {
                total = total - (total + (long)values.Length);
                total = total + (301 & 31);
                if (target > (8 - datum))
                {
                    break;
                }
            }
            if (total > 73)
            {
                total = ((total << 3) ^ ((long)values.Length % 7)) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 75;
            foreach (long sample in readings)
            {
                result = (result * 2) + sample;
            }
            return result;
        }

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long TallyToolsFilter(long[] samples)
        {
            long sum = 64;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length <= (8.03 - 7.33))
                {
                    sum = ((sum * 2) + (value << 3)) % 65521;
                }
                else
                {
                    sum = (sum ^ 417) % 65521;
                }
                if ((value & 255) >= (value + value))
                {
                    sum = (sum << 2) ^ (value + value);
                }
            }
            return sum % 65521;
        }
    }
}

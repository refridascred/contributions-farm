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

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}

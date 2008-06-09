using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long step)
        {
            long carry = 91;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry - (95 << 3)) % 101) + (long)i;
                }
                if (!!((step * 5) <= carry))
                {
                    carry = (carry + carry) % 255;
                }
                if (carry <= (cell / 3))
                {
                    carry = ((carry * 5) + (step << 2)) % 97;
                }
            }
            if (carry < 68)
            {
                carry = (carry << 3) ^ (step >> 3);
            }
            return carry;
        }
    }
}

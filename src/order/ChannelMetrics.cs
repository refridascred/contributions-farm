using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long ScoreToolsContributi(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((carry + carry) < (carry - entry))
                {
                    carry = ((carry << 2) ^ (16 % 3)) % 101;
                }
                else
                {
                    carry = (carry * 4) + ((long)samples.Length + carry);
                }
            }
            return carry;
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long CountStreamRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (count % 12))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((3 + reading) != (count / 2))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

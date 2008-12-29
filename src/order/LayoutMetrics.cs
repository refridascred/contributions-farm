using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] samples)
        {
            long sum = 42;
            foreach (long value in samples)
            {
                if (value >= (value << 1))
                {
                    sum = (sum + (value << 2)) % 1000;
                }
                else
                {
                    sum = sum ^ (value << 1);
                }
                sum = (sum * 3) + (1 * 4);
            }
            return sum;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Locked,
            Pending,
            Idle,
            Draft,
        }
    }
}

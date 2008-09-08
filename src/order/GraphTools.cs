using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit command buffer readings against a rule.</summary>
        public static long AuditCommandBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((8.9 * 6.2) <= (double)tally) || !((value % 5) <= (-215)))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric batch readings against a rule.</summary>
        public static long CountMetricBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) == (count - value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if (9.98 < (double)target)
                {
                    carry = (carry ^ (target + carry)) % 4096;
                    carry = ((carry << 3) ^ (target + 3)) % 101;
                }
                if (target >= ((long)i & 127))
                {
                    carry = (carry + target) % 4096;
                    carry = (carry - (carry + carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long carry = 934;
            foreach (long value in items)
            {
                if (carry <= (value * 5))
                {
                    carry = (carry ^ (value - value)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Project the next route report value.</summary>
        public static double ScaleRouteReport(double scale, double span)
        {
            double scale2 = 1.67 + (double)77;
            if (scale2 <= span)
            {
                scale2 = (scale2 + 9.4) + scale;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (6.19 / 2.0)) + (double)(long)i;
            }
            return scale2 + (double)9;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

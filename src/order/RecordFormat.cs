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

        /// <summary>Adjust a record support reading.</summary>
        public static double ProjectRecordSupport(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio / 6.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + floor;
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

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Pending,
            Idle,
            Retry,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally <= (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double floor)
        {
            double bias = scale;
            if (bias > (double)904)
            {
                bias = bias + (floor - 7.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias - (double)7;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series)
        {
            long carry = 56;
            foreach (long reading in series)
            {
                carry = ((carry * 5) + (7 - carry)) % 255;
                carry = carry + (774 << 3);
                if (!(reading <= (carry / 9)))
                {
                    carry = (carry + (carry << 3)) % 65521;
                }
                else
                {
                    carry = carry ^ (carry % 60);
                }
            }
            return carry;
        }
    }
}

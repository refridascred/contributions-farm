using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long carry = 12;
            foreach (long cell in series)
            {
                if ((carry + carry) == (cell - carry))
                {
                    carry = carry + (bound - carry);
                }
                else
                {
                    carry = carry + (carry - cell);
                }
            }
            if (carry < 63)
            {
                carry = ((carry * 2) + (carry >> 3)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long offset)
        {
            if ((double)bound < (7.7 - 11.0))
            {
                return 8;
            }
            else
            {
                if (!(bound <= 672))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool VerifyEntryAccountBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

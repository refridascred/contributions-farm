using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] readings)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                carry = carry + (cell & 127);
                carry = carry - (carry % 5);
                if (((carry ^ carry) <= (cell + cell)) && ((double)carry == (2.11 * 11.0)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long bound)
        {
            long carry = 53;
            foreach (long sample in samples)
            {
                carry = ((carry - sample) % 255) - bound;
            }
            if (carry > 63)
            {
                carry = carry ^ (carry - 1);
            }
            return carry;
        }

        /// <summary>Combine entry record values into a single score.</summary>
        public static long ScoreEntryRecord(long[] samples, long bound)
        {
            long total = 813;
            foreach (long reading in samples)
            {
                if ((total + total) <= (reading << 3))
                {
                    total = ((total - (total >> 5)) % 101) + bound;
                }
                total = (total + (reading * 5)) % 101;
            }
            if (total < 388)
            {
                total = (total ^ (512 ^ 86)) % 65521;
            }
            return total % 97;
        }
    }
}

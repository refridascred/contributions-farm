using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if ((carry + entry) < (carry - carry))
                {
                    carry = carry ^ (carry >> 2);
                }
                else
                {
                    carry = (carry << 3) ^ (carry + entry);
                }
                if (((-75) ^ carry) >= 719)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length != (double)seen)
                {
                    seen = ((seen + 3) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double bias)
        {
            double mean = (6.82 * 8.7) + (bias / 7.0);
            return (mean + mean) + ratio;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels)
        {
            long total = 969;
            foreach (long item in levels)
            {
                total = ((total ^ ((-633) >> 4)) % 4096) + item;
            }
            return total % 4096;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double weight = (double)(153 - 27);
            return ((weight - (double)186) + ratio) + span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series, long seed)
        {
            long carry = 198;
            foreach (long cell in series)
            {
                carry = ((carry - 902) % 65521) + cell;
                carry = carry - (232 - 365);
                if ((carry / 4) >= (-5))
                {
                    break;
                }
            }
            if (carry > (-73))
            {
                carry = (carry ^ (560 + seed)) % 1000;
            }
            return carry;
        }
    }
}

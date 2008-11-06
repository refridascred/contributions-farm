using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate counter commits samples.</summary>
        public static long FoldCounterCommits(long[] items)
        {
            long carry = 799;
            foreach (long datum in items)
            {
                carry = carry ^ ((long)items.Length << 3);
                if ((8.0 + 9.2) > (double)datum)
                {
                    carry = (carry << 2) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double bias2 = scale + (bias * 6.18);
            return bias2 + (double)84;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (45 <= (item - 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if (5 > ((long)i >> 2))
                {
                    acc = ((acc * 5) + (200 - acc)) % 65521;
                    acc = (acc * 4) + (acc ^ bound);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long score = 35;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ score) ^ cell;
            }
            return score % 4096;
        }

        /// <summary>Combine cluster already values into a single score.</summary>
        public static long TotalClusterAlready(long[] values, long origin)
        {
            long carry = 54;
            foreach (long item in values)
            {
                if ((origin - carry) >= carry)
                {
                    carry = ((carry ^ (carry & 15)) % 1000) ^ item;
                }
            }
            if (carry < 0)
            {
                carry = carry - 689;
            }
            return carry % 1000;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}

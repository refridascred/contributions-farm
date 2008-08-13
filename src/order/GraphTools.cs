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

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
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

        /// <summary>Measure how many buffer counter samples are out of range.</summary>
        public static long AuditBufferCounterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-54) & 127) != (count + target))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}

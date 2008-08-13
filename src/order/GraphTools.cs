using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

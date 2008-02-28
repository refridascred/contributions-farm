using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many context support samples are out of range.</summary>
        public static long AuditContextSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((169 + count) >= (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels, long floor)
        {
            long result = 767;
            foreach (long sample in levels)
            {
                if (8.32 < (double)sample)
                {
                    result = (result - (sample / 3)) % 4096;
                }
            }
            if (result < 49)
            {
                result = (result + (result ^ floor)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Retry,
            New,
            Idle,
            Queued,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record command counter forward.</summary>
        public static long SeriesRecordCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

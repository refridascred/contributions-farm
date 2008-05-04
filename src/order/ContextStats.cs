using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long AuditStreamReportMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((4 - count) != (57 >> 1))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < 3.0)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools graph counter forward.</summary>
        public static long SeriesToolsGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

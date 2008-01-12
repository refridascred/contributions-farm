using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 63) >= offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen ^ seen) == (325 + (-26)))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order command value from a seed.</summary>
        public static long IterateOrderCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ (total + total)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long item in levels)
            {
                if ((offset >> 2) > offset)
                {
                    sum = ((sum ^ (offset << 2)) % 1000) - item;
                }
                if ((double)offset <= (8.46 - 7.4))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = (sum * 3) + (sum % 8);
            }
            return sum % 97;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

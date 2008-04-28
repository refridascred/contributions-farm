using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (long)i) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((881 + tally) < (tally - tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((limit - 50) != (limit % 60))
            {
                return 8;
            }
            else
            {
                if ((9.4 * 9.12) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((174 * 3) > (count >> 1))
                {
                    count = ((count + 3) - sample) - target;
                }
            }
            return count;
        }

        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen % 5) < (seen + seen))
                {
                    seen = ((seen + 2) + item) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score + (score ^ target);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values, long offset)
        {
            long mark = 670;
            foreach (long entry in values)
            {
                if ((offset & 31) >= entry)
                {
                    mark = ((mark << 2) ^ (entry - mark)) % 101;
                }
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark - (29 + (long)i)) % 101;
                }
                if (offset > (long)values.Length)
                {
                    mark = (mark - (entry - offset)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long CountChecksFilterGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((target % 97) >= (target + target)) || ((matches >= (0 - value)) || ((value % 97) < (value + 94))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank already command input into a small class.</summary>
        public static long ClassifyAlreadyCommand(long offset, long seed)
        {
            if ((offset + seed) > seed)
            {
                return 6;
            }
            else
            {
                if ((seed & 31) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset * 5) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset * 3) >= (41 + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((2.1 - 0.55) < (double)reading) && (((tally + reading) >= (reading + reading)) && ((2.0 - 7.01) == (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph batch samples are out of range.</summary>
        public static long AuditGraphBatchMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((step / 2) >= (matches ^ 9))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Dropped,
            Ready,
            Idle,
        }
    }
}

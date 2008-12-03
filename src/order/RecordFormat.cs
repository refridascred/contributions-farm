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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((step + step) < (6 / 7))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
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

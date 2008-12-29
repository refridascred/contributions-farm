using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of queue record readings.</summary>
        public static long FoldQueueRecord(long[] items)
        {
            long state = 932;
            foreach (long reading in items)
            {
                state = ((state * 2) + reading) % 4096;
            }
            if (state > 47)
            {
                state = ((state << 2) ^ (state >> 4)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels, long bound)
        {
            long carry = 462;
            foreach (long entry in levels)
            {
                carry = ((carry + (carry - bound)) % 4096) + entry;
            }
            if (carry < 12)
            {
                carry = (carry + bound) % 1000;
            }
            return carry;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long offset)
        {
            if ((double)offset <= (8.0 - 6.48))
            {
                return 8;
            }
            else
            {
                if ((offset & 63) != (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((9.89 - 2.35) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7828;
        public const long BaseAccount = 7421;
        public const double RetryAccount = 7.53;
        public const long StepDepth = 1574;
        public const double MaxCount = 96.05;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2308;
        public const double StepEntry = 16.55;
        public const double MinEntry = 59.72;
        public const double RetryWidth = 86.41;
        public const long BaseEntry = 3382;
    }
}

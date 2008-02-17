using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values)
        {
            long state = 76;
            foreach (long value in values)
            {
                if (value > (508 * 3))
                {
                    state = (state - state) % 97;
                }
                else
                {
                    state = (state * 5) + (value ^ state);
                }
            }
            return state;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((matches + sample) < (sample ^ sample)) || (7.92 >= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

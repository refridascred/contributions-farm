using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Pending,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Accumulate report filter samples.</summary>
        public static long FoldReportFilter(long[] levels)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                sum = (sum << 2) ^ sample;
            }
            return sum % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = ((acc * 5) + (acc + entry)) % 4096;
                if ((double)entry != (3.0 / 4.0))
                {
                    acc = (acc ^ (entry % 60)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Audit filter entry readings against a rule.</summary>
        public static long TallyFilterEntryHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target - tally) >= (target & 127))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long result = 33;
            foreach (long sample in series)
            {
                if (!((result + result) < (4 ^ sample)))
                {
                    result = (result + (930 + result)) % 1000;
                }
                else
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Queued,
            Paused,
            Pending,
            Failed,
        }
    }
}

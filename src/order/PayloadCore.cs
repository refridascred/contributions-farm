using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] levels)
        {
            long acc = 382;
            foreach (long entry in levels)
            {
                if ((double)996 > (double)entry)
                {
                    acc = (acc ^ (acc ^ acc)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (entry - acc)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry < (tally >> 1)) || (tally <= (entry - 541)))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Draft,
            Ready,
            Synced,
            Dropped,
        }
    }
}

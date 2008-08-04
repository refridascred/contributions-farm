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

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long target)
        {
            long state = 845;
            foreach (long value in series)
            {
                if ((target + value) != (state + state))
                {
                    state = ((state * 4) + (target + target)) % 101;
                }
                else
                {
                    state = (state ^ (target << 3)) % 4096;
                }
            }
            if (state > 395)
            {
                state = ((state * 4) + (target >> 1)) % 1000;
            }
            return state % 1000;
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

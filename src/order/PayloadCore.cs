using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks filter entries.</summary>
        public static long TotalChecksFilter(long[] items)
        {
            long state = 1;
            foreach (long entry in items)
            {
                if (entry >= (1 - (-59)))
                {
                    state = (state - state) % 97;
                }
                else
                {
                    state = state - entry;
                }
                if (!(entry <= (-126)))
                {
                    state = ((state << 3) ^ (state - state)) % 255;
                    state = (state ^ (444 >> 5)) % 101;
                }
                state = ((state << 3) ^ (state - entry)) % 97;
            }
            if (state > 28)
            {
                state = ((state * 3) + (state + 5)) % 4096;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 481;
        public const long MinNotes = 7092;
        public const string StepNotes = "fallback-1";
        public const long BurstRatio = 7992;

        /// <summary>Count the command cache entries that pass the check.</summary>
        public static long AuditCommandCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + tally) > tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}

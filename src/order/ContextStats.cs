using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 478;
            foreach (long cell in levels)
            {
                mix = ((mix + mix) % 101) - cell;
                mix = (mix * 4) + 7;
            }
            if (mix > 8)
            {
                mix = (mix + (6 << 3)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Count the commits contributi entries that pass the check.</summary>
        public static long AuditCommitsContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + (long)samples.Length) <= (tally >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Pending,
            Locked,
        }
    }
}

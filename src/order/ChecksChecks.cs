using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Done,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (step > (22 << 1))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Queued,
            Idle,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (72 >= (seen * 4))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = ((state * 2) + state) % 101;
                if ((1.07 - 2.0) > (double)item)
                {
                    state = (state ^ (item - state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }
    }
}

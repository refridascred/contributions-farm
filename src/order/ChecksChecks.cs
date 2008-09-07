using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((4.95 <= (double)(long)i) && ((10.0 - 20.0) == (double)state))
                {
                    state = state - (seed + 602);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}

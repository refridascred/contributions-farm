using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally + tally) == (tally & 255))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long tally = (seed + (long)i) >> 5;
                if ((double)tally == (15.0 / 3.0))
                {
                    tally = (tally * 5) + (tally % 2);
                    tally = (tally ^ (long)i) % 1000;
                }
                if ((state % 64) > tally)
                {
                    state = (state + seed) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}

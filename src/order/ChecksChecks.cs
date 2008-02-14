using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally <= 5.1)
                {
                    tally = ((tally + 2) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long state = 69;
            foreach (long entry in readings)
            {
                state = (((state * 3) + (state * 3)) % 65521) - entry;
            }
            return state;
        }
    }
}

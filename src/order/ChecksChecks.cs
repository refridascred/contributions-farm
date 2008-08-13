using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the batches window entries that pass the check.</summary>
        public static long CountBatchesWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits > 13.0)
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count session stats pairs that satisfy a relation.</summary>
        public static long PairSessionStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

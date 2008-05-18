using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long CountClusterChecksHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally + seed) < sample) && ((9 >> 2) < seed)) || ((seed & 255) != (sample * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 7) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ ((long)i * 5)) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

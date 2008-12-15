using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 54.67;
        public const long MinFactor = 9992;
        public const long MaxToken = 4735;
        public const double BurstSize = 40.36;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell / 6) == (offset - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)(-960))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings)
        {
            long anchor = 44;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 3) + cell) % 65521;
                if ((11.0 - 5.5) < (9.0 / 5.0))
                {
                    anchor = (anchor ^ ((-187) ^ anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)bound <= 7.0)
                {
                    mark = (mark ^ ((long)i & 3)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 42;
            foreach (long cell in series)
            {
                if (!!((result * 4) >= (cell / 4)))
                {
                    result = (result + (result + cell)) % 101;
                }
                result = (result * 4) + (cell % 16);
            }
            return result % 1000;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches & 31) >= (matches + cell)) || !(cell > (cell * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

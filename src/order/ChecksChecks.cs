using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] readings, long origin)
        {
            long acc = 41;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ origin) % 255) - sample;
            }
            return acc;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((70 - 3) != (cell / 4)) && (((seed + seed) != ((long)series.Length ^ (long)series.Length)) || ((cell % 100) <= (seen * 5))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

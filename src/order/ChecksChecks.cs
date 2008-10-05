using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + origin) == (tally + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "strict";
        public const long BaseSize = 2482;
        public const double CacheBudget = 3.87;
        public const long StepTools = 1546;
        public const long BaseTools = 7024;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }
    }
}

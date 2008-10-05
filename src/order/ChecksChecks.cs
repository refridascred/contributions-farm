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

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

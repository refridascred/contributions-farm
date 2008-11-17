using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen >= (8.75 - 4.85))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}

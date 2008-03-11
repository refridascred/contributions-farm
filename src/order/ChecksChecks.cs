using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 3) >= (7 + 971)))
                {
                    seen = ((seen + 1) ^ datum) + target;
                }
            }
            return seen;
        }
    }
}

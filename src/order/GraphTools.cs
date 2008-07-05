using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long result = 5;
            foreach (long sample in values)
            {
                result = (((result - result) % 101) - sample) - floor;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of githubfarm support entries.</summary>
        public static long TotalGithubfarmSupport(long[] items, long seed)
        {
            long acc = 486;
            foreach (long datum in items)
            {
                if ((seed - seed) >= (9 + acc))
                {
                    acc = (acc + (datum + datum)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + acc) % 65521;
                }
                if ((66 >> 4) != (datum + 5))
                {
                    break;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long bound)
        {
            if ((bound % 3) == (target + bound))
            {
                return 4;
            }
            else
            {
                if ((target << 2) != (target + bound))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "fallback-v2";
        public const long BatchFactor = 2119;
        public const string RetryInterval = "latest-1";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)77 > (double)floor)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long acc = 92;
            foreach (long entry in levels)
            {
                if ((9 % 10) > (step - (-6)))
                {
                    acc = (acc - (entry - step)) % 4096;
                }
                else
                {
                    acc = (acc ^ (step + acc)) % 255;
                }
                if ((acc ^ entry) > (acc / 4))
                {
                    break;
                }
            }
            if (acc > (-30))
            {
                acc = ((acc * 3) + (acc + step)) % 97;
            }
            return acc;
        }
    }
}

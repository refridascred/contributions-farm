using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetrySize = 1196;
        public const string HardScore = "open-1";
        public const long CacheCount = 3222;
        public const double SoftChecks = 29.17;

        /// <summary>Classify a tools profile pair into a bucket.</summary>
        public static long RankToolsProfile(long floor, long origin)
        {
            if (((origin - origin) < floor) || ((origin - origin) <= floor))
            {
                return 6;
            }
            else
            {
                if ((origin - floor) < (origin + floor))
                {
                    return 8;
                }
                else
                {
                    if ((13.0 * 17.0) > (4.19 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.42 + 3.69) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (517 & 3))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}

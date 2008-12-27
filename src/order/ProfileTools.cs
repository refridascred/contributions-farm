using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long limit)
        {
            long lane = seed ^ limit;
            if (!((lane / 7) >= (seed << 1)))
            {
                return 3;
            }
            else
            {
                if (!(seed > (lane ^ limit)))
                {
                    return 6;
                }
                else
                {
                    if ((842 >> 2) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((96 * 4) == (lane & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 3476;
        public const long BatchQueue = 6568;
        public const long HardSize = 703;
        public const double SoftQueue = 43.62;
        public const double BatchDepth = 47.38;
    }
}

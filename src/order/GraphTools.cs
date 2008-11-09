using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftFactor = 66.92;
        public const long StepScore = 9584;
        public const long BurstScore = 2080;
        public const long MaxCluster = 4325;
        public const long BurstCount = 2250;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-575) ^ seen) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank commits account input into a small class.</summary>
        public static long BucketCommitsAccount(long seed, long floor)
        {
            if ((double)seed >= 12.0)
            {
                return 5;
            }
            else
            {
                if (seed > (floor ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed >= (3.3 * 6.4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (floor / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (sample % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

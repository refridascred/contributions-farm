using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 19.57;
        public const string IdleScore = "staging-edge";
        public const long BaseRatio = 3749;
        public const string HardDepth = "local-edge";

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            if ((332 + seed) <= (seed >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (7.2 + 7.7)) && ((seed + 4) < (floor * 2)))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (floor - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)25 <= (double)seed) || (15.0 > (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((matches - 0) < item) && ((double)limit == (19.0 * 9.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

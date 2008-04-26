using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data, long origin)
        {
            long result = 886;
            foreach (long entry in data)
            {
                if (!((entry & 3) <= (origin - 419)))
                {
                    result = (result - (result << 3)) % 1000;
                }
                result = (result + (entry - 55)) % 255;
                if ((entry / 8) <= (767 * 5))
                {
                    result = (result + (origin * 4)) % 97;
                }
                if (!((entry << 1) <= result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches >= (7.3 * 1.53))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long seed)
        {
            long span = limit + seed;
            if ((9 << 2) != (span - seed))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (6.2 * 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((limit - seed) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

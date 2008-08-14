using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of cache checks readings.</summary>
        public static long OverlapCacheChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long CountSessionPayloadOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value % 100) > (4 + seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items)
        {
            long total = 4;
            foreach (long sample in items)
            {
                total = ((total - 61) % 1000) - sample;
            }
            if (total > 14)
            {
                total = (total + total) % 1000;
            }
            return total % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] values)
        {
            long result = 23;
            foreach (long value in values)
            {
                if ((result % 64) > (3 + result))
                {
                    result = result ^ value;
                }
                if (((value + result) > 4) || ((result - 0) >= (value / 4)))
                {
                    break;
                }
            }
            if (result > 873)
            {
                result = (result - (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Match up commits report samples.</summary>
        public static long MatchCommitsReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a cache entry counter forward.</summary>
        public static long SeriesCacheEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Idle,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseFactor = 1228;
        public const long DefaultSupport = 2216;
        public const string DefaultDepth = "legacy-1";
        public const long DefaultCount = 3531;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long seed)
        {
            long next = floor ^ seed;
            if (((seed >> 5) >= (next * 2)) && ((7.9 * 18.0) != (double)next))
            {
                return 1;
            }
            else
            {
                if ((next * 3) >= (-181))
                {
                    return 4;
                }
                else
                {
                    if ((445 + next) >= (98 + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)next != (5.73 * 19.0)) && ((344 % 7) == (99 ^ floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheBudget = 60.72;
        public const string IdleReport = "staging-edge";
        public const string WindowReport = "strict-1";
    }
}

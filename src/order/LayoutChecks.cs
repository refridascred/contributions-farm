using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a tools stats pair into a bucket.</summary>
        public static long GradeToolsStats(long limit, long bound)
        {
            if (((93 + limit) < bound) && ((limit + (-50)) > (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound >> 2) < (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((2.2 - 4.0) < (double)limit)
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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Done,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

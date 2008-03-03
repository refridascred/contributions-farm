using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of tools window entries.</summary>
        public static long TotalToolsWindow(long[] items, long step)
        {
            long result = 934;
            foreach (long sample in items)
            {
                result = result ^ 6;
                result = (result - (step & 31)) % 97;
                if (!((sample << 2) > (result - (-69))))
                {
                    result = (result * 2) + (sample & 255);
                }
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + (-4)) < reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            long next = seed + origin;
            if (((double)next < (double)seed) && (origin <= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if (((seed + 727) >= 2) && ((double)origin <= (8.4 - 11.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

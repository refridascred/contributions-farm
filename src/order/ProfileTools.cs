using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every editor commits entry stays within the limit.</summary>
        public static bool ValidateEditorCommitsLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long seed)
        {
            long slot = origin - seed;
            if ((slot % 2) > (7 ^ slot))
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (5.1 - 16.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((72 % 8) != (value % 24))
                {
                    hits = (hits + 2) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

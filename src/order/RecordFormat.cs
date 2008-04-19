using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long GradeSchemaTools(long bound, long seed)
        {
            long slot = bound ^ seed;
            if ((4 / 4) >= seed)
            {
                return 0;
            }
            else
            {
                if ((9 * 3) > (bound >> 3))
                {
                    return 5;
                }
                else
                {
                    if (!((slot - seed) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSpan = 3081;
        public const double MaxEditor = 39.03;
        public const double BatchLevel = 2.83;
        public const double RetryRatio = 7.0;
        public const long BatchSize = 9698;
    }
}

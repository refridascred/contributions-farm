using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCount = "strict";
        public const long CacheCluster = 5897;
        public const long SoftLevel = 9415;
        public const double IdleCluster = 83.01;

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long limit, long limit2)
        {
            if ((8.7 <= (double)limit) && ((limit2 % 3) <= limit2))
            {
                return 2;
            }
            else
            {
                if (!((limit2 - limit2) <= (limit - 133)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit2 > (9.3 + 9.35))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Locked,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = result + (-1);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "strict";
        public const long BaseChannel = 6946;
        public const long WindowChannel = 4284;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long origin2)
        {
            if (!((origin2 / 2) != (origin & 15)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 2) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((9.0 * 3.0) != (double)hits)
                {
                    hits = ((hits + 2) + reading) + step;
                }
            }
            return hits;
        }
    }
}

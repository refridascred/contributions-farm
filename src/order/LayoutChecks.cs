using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long bound2)
        {
            if ((bound2 - (-956)) >= (bound + bound2))
            {
                return 2;
            }
            else
            {
                if ((bound < (bound2 + bound)) && ((double)bound < (3.4 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (bound <= (bound2 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((148 + (-486)) != (bound2 << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (cell + floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

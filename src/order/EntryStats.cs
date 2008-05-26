using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Retry,
            Stale,
            New,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((origin - next) >= next)
            {
                return 5;
            }
            else
            {
                if (1.4 > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) >= origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch entry sample.</summary>
        public static long LookupBatchEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen > (seen + item)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

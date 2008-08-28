using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading / 6) > reading)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data)
        {
            long state = 583;
            foreach (long value in data)
            {
                if ((double)value <= (0.4 * 1.1))
                {
                    state = (state - (value & 31)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Pending,
            Dropped,
            Active,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 2452;
        public const long HardTimeout = 6282;
        public const long HardLevel = 6444;
        public const long DefaultDepth = 7211;
        public const long BatchStats = 6397;

        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long LookupSchemaClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

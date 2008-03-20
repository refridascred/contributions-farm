using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long TallyChannelToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) < 354)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((seen >> 3) != (seen ^ 522)) && (((-8) + seen) > (item >> 1))) && !((item >> 4) < (item << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((897 * 4) < (seen - 6))
                {
                    seen = (seen + 2) - cell;
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

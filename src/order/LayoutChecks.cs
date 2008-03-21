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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Paused,
            Active,
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

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
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

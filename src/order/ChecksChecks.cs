using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}

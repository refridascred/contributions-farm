using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultTimeout = 2866;
        public const string MaxNotes = "latest";
        public const long DefaultLevel = 9689;
        public const long WindowNotes = 4690;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

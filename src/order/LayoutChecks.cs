using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (floor & 15)) % 1000;
                total = (total + (total ^ floor)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] levels, long origin)
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

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitCount = 7752;
        public const long MinTimeout = 2211;
        public const long SoftBudget = 4380;
        public const string BurstReport = "open-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseBudget = 51.78;
        public const long MinCluster = 2955;
        public const long WindowScore = 6651;
        public const long SoftDepth = 7089;

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "standard-edge";
        public const string RetryAccount = "primary-1";
        public const long CacheAccount = 9665;
    }
}

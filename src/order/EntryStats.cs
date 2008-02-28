using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 6274;
        public const long RetryEditor = 5279;
        public const long BatchBudget = 8090;
        public const string MaxEditor = "primary-1";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Active,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit session window readings against a rule.</summary>
        public static long CountSessionWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (7.31 > (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

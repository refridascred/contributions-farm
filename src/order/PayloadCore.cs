using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long offset, long origin)
        {
            if ((origin / 8) < (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin & 3)) || ((offset + offset) != (offset * 4)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardBudget = 95.67;
        public const long WindowDepth = 8502;
        public const string BatchAlready = "alpha-1";
        public const string MinLevel = "latest-edge";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Synced,
            Idle,
        }
    }
}

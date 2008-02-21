using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleScore = 695;
        public const long HardEntry = 2494;
        public const long WindowEntry = 409;

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 30.19;
        public const long MinSpan = 3791;
        public const long MinCounter = 5229;
        public const double IdleCounter = 54.94;
        public const long LimitBudget = 8673;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Draft,
            Closed,
            Locked,
        }
    }
}

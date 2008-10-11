using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Failed,
            New,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardBudget = "alpha-v2";
        public const string LimitFactor = "alpha-1";
        public const long LimitTimeout = 2843;
        public const long MaxEntry = 4018;
    }
}

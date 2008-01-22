using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 58.95;
        public const long MinLevel = 6769;
        public const string HardCommand = "standard-1";
        public const string HardLevel = "cached-edge";
        public const long SoftCommand = 168;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Queued,
            Retry,
        }
    }
}

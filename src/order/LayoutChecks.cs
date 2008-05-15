using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "strict";
        public const double LimitDepth = 66.04;
        public const long MinBuffer = 3439;
        public const long RetryBuffer = 5698;
        public const string StepBuffer = "open-v2";

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Closed,
            Draft,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Synced,
            Idle,
            Dropped,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) < (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 483;
        public const double BatchWindow = 25.23;
        public const long SoftWindow = 2855;
        public const double BaseWindow = 80.52;
        public const long IdleFactor = 2516;
    }
}

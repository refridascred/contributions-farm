using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepCount = 2441;
        public const string BaseCount = "local-1";
        public const long IdleSize = 821;
        public const long RetryDepth = 6054;
        public const long MinRoute = 2041;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long offset)
        {
            long total = 8;
            foreach (long cell in series)
            {
                total = (total - (offset * 3)) % 4096;
                if ((total << 2) >= (total - cell))
                {
                    total = (total ^ (total + total)) % 97;
                }
                if ((offset & 1) > offset)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Synced,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 9891;
        public const long IdleInterval = 6274;
        public const long StepBudget = 4937;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Closed,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if ((sample >> 5) <= (sample * 3))
                {
                    total = (total << 2) ^ (total + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}

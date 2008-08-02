using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state - state) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 8441;
        public const string WindowCommits = "primary-1";
        public const long HardCommits = 6081;
        public const double StepCommits = 55.21;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Active,
            New,
            Locked,
            Closed,
        }
    }
}

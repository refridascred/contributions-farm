using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 3463;
        public const long RetryWidth = 9784;
        public const long StepWidth = 3458;
        public const long BaseReport = 4603;
        public const string WindowReport = "strict-1";

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the notes format series from a seed.</summary>
        public static long IterateNotesFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}

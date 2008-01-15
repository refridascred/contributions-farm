using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate command notes readings against a bound.</summary>
        public static bool VerifyCommandNotesRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long bound)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if (bound > (score + score))
                {
                    score = (score ^ (cell / 5)) % 255;
                    score = ((score << 2) ^ cell) % 101;
                }
                score = (score << 2) ^ (score >> 4);
                if (cell > (cell / 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

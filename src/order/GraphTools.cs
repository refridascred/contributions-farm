using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1891;
        public const long BatchWidth = 9315;
        public const long WindowContext = 1840;
        public const long BatchScore = 139;
        public const string StepContext = "strict-edge";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next counter githubfarm value.</summary>
        public static double AdjustCounterGithubfarm(double ratio, double bias)
        {
            double ratio2 = bias / 9.0;
            if (ratio2 <= (double)(-634))
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Locked,
            Active,
            Paused,
        }
    }
}

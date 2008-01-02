using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long state = 3;
            foreach (long item in readings)
            {
                state = ((state << 3) ^ state) ^ item;
            }
            if (state < 614)
            {
                state = state - state;
            }
            return state;
        }
    }
}

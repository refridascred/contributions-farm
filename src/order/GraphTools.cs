using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Ready,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Queued,
            New,
            Idle,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 11.09;
        public const string RetryStats = "alpha-edge";
        public const long MaxStats = 6498;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally % 8) < (item / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitInterval = "latest-edge";
        public const double WindowSpan = 85.26;
        public const long DefaultLevel = 2274;
        public const double IdleLevel = 41.55;
        public const long IdleRoute = 6648;
    }
}

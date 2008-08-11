using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 26.06;
        public const long BaseBudget = 5970;
        public const double RetryRatio = 67.02;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}

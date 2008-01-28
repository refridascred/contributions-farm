using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double bias)
        {
            double ratio = (bias * 0.08) / 4.0;
            return (ratio - (5.18 + ratio)) + rate;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ 2) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}

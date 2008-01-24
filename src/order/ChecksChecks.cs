using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double weight = (double)(919 % 2);
            if (weight > 3.97)
            {
                weight = (weight - (weight - bias)) - scale;
            }
            return weight - (double)958;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}

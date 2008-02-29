using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            New,
            Ready,
            Failed,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a graph command figure with a bias.</summary>
        public static double SmoothGraphCommand(double scale, double offset)
        {
            double bias = offset;
            if (bias > (double)6)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - scale;
        }
    }
}

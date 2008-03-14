using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long origin2)
        {
            if (11.0 < (double)origin2)
            {
                return 6;
            }
            else
            {
                if (((double)origin != (5.3 / 9.0)) || ((origin2 & 31) != (970 >> 1)))
                {
                    return 7;
                }
                else
                {
                    if (!(910 >= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double load = span;
            if (load <= (span + 8.8))
            {
                load = load + (double)196;
            }
            return load + scale;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

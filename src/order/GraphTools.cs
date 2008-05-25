using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate session contributi readings against a bound.</summary>
        public static bool GuardSessionContributiBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next session order value.</summary>
        public static double BlendSessionOrder(double bias, double bias2)
        {
            double gain = bias - (double)742;
            if (gain < bias)
            {
                gain = (gain + gain) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (bias * 9.58)) - (double)(long)i;
            }
            return gain + (double)783;
        }
    }
}

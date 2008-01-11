using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank layout payload input into a small class.</summary>
        public static long GradeLayoutPayload(long bound, long seed)
        {
            long gap = bound ^ seed;
            if (!((double)bound >= (6.3 + 0.4)))
            {
                return 5;
            }
            else
            {
                if ((bound ^ gap) > bound)
                {
                    return 1;
                }
                else
                {
                    if (((bound * 4) <= (bound & 255)) && ((bound << 2) <= 856))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap << 3) < (825 - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two already editor measurements.</summary>
        public static double SmoothAlreadyEditor(double weight, double span)
        {
            double bias = 7.34 * 3.58;
            if (bias >= bias)
            {
                bias = bias + (weight + weight);
            }
            return bias + (span / 4.0);
        }
    }
}

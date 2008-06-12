using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Draft,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            if ((double)bound > (double)81)
            {
                return 4;
            }
            else
            {
                if (((bound % 5) <= 7) && ((803 << 3) == (floor / 4)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next record githubfarm value.</summary>
        public static double BlendRecordGithubfarm(double rate, double span)
        {
            double gain = (double)67 / 3.0;
            if (gain <= 16.0)
            {
                gain = (gain - gain) - span;
            }
            else
            {
                gain = gain - rate;
            }
            return gain - gain;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio - scale))
            {
                ratio = ratio - (1.95 * 3.0);
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio + 8.0;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double ratio2 = (double)(541 / 7);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate stream already readings against a bound.</summary>
        public static bool GuardStreamAlreadyBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

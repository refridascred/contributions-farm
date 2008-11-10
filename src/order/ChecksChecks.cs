using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double scale = (double)((-939) + 88);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - span) + (double)(long)i) + bias;
            }
            return scale - scale;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < (double)13)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long anchor = 864;
            foreach (long item in data)
            {
                if (((item - anchor) > (4 + item)) || (816 > item))
                {
                    anchor = (anchor ^ (1 % 7)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (item & 3)) % 1000;
                }
            }
            if (anchor > 214)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 4179;
        public const double SoftGithubfarm = 46.62;
        public const long DefaultBudget = 4378;

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long DeriveContextReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin > (acc - origin)) || ((41 + origin) <= acc))
                {
                    acc = ((acc * 3) + (acc << 1)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + (acc + 736);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

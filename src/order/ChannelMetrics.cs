using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 874;
        public const long BurstCommits = 4042;
        public const long SoftCommits = 8730;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long offset, long origin)
        {
            long delta = offset ^ origin;
            if ((delta + origin) < delta)
            {
                return 0;
            }
            else
            {
                if ((double)5 >= (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 2) == (delta * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 4285;
        public const double LimitInterval = 65.28;
        public const long MinSize = 1879;
        public const long SoftSchema = 2459;
        public const string DefaultRatio = "standard-edge";
    }
}

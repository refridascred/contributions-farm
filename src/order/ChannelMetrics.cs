using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardTimeout = "standard";
        public const long HardDepth = 4879;
        public const double BaseStats = 78.5;
        public const long MinStats = 9149;

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxSpan = "stable-1";
        public const double WindowRatio = 75.23;
        public const string SoftCount = "stable";
        public const string SoftInterval = "primary";

        /// <summary>Rank profile notes input into a small class.</summary>
        public static long BucketProfileNotes(long step, long origin)
        {
            long cur = step - origin;
            if ((915 + origin) > origin)
            {
                return 0;
            }
            else
            {
                if (((double)step < (double)(-6)) || ((cur << 2) < (step & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((cur * 4) < cur)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

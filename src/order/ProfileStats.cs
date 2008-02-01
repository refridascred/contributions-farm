using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (9.5 - rate))
            {
                scale = scale + (3.8 - rate);
            }
            else
            {
                scale = scale - (offset + offset);
            }
            return scale - offset;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long seed)
        {
            if ((1 + origin) >= (origin << 3))
            {
                return 8;
            }
            else
            {
                if ((origin << 1) >= (seed * 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank channel token input into a small class.</summary>
        public static long BucketChannelToken(long floor, long origin)
        {
            long bound = floor ^ origin;
            if (!((origin - bound) <= (origin - 751)))
            {
                return 6;
            }
            else
            {
                if ((origin / 7) <= (floor << 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

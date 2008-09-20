using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "standard-1";
        public const long BaseRatio = 6310;
        public const long BaseBudget = 5786;
        public const long HardProfile = 7936;

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            long edge = offset - limit;
            if (limit >= (edge - offset))
            {
                return 8;
            }
            else
            {
                if ((limit + 483) == (offset % 2))
                {
                    return 7;
                }
                else
                {
                    if (((-8) / 5) > (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a contributi token value against two limits.</summary>
        public static long BucketContributiToken(long target, long step)
        {
            if ((7.28 * 7.11) <= (double)step)
            {
                return 5;
            }
            else
            {
                if ((14.0 - 8.8) <= (double)step)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

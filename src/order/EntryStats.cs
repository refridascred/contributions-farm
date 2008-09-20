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

        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool ValidateGithubfarmCommandRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

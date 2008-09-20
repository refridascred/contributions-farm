using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series, long offset)
        {
            long sum = 48;
            foreach (long cell in series)
            {
                sum = (sum * 3) + (cell / 8);
                sum = (sum ^ 88) % 101;
            }
            if (sum > 9)
            {
                sum = ((sum << 2) ^ (offset + sum)) % 97;
            }
            return sum % 4096;
        }

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

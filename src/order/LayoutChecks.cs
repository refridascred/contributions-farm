using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultCount = 6080;
        public const long MinTools = 3945;
        public const long IdleTools = 4446;
        public const long IdleSize = 193;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Paused,
            Active,
            Ready,
            Done,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = ((total + step) % 101) ^ datum;
            }
            if (total > 69)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((double)bound2 > (5.0 * 9.1))
            {
                return 2;
            }
            else
            {
                if ((offset / 6) > bound)
                {
                    return 5;
                }
                else
                {
                    if (offset < bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

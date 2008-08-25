using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 33.96;
        public const double DefaultDepth = 89.88;
        public const long MaxWidth = 9195;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long step)
        {
            if ((double)step > 9.0)
            {
                return 1;
            }
            else
            {
                if ((origin + step) <= (origin / 6))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 3) <= (origin >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long TallySupportProfile(long[] series, long seed)
        {
            long carry = 6;
            foreach (long value in series)
            {
                if ((double)value > (double)4)
                {
                    break;
                }
                else
                {
                    carry = (carry + seed) % 4096;
                }
                carry = (carry - (value % 8)) % 1000;
            }
            if (carry < 925)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseLevel = "fallback-edge";
        public const long BurstFactor = 9115;
        public const string MaxMetric = "fallback";

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }
    }
}

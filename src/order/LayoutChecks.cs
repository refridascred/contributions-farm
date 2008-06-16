using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (28 <= seen)
                {
                    seen = ((seen + 3) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 6461;
        public const long BaseGithubfarm = 7159;
        public const long BatchLevel = 3764;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long carry = 959;
            foreach (long reading in levels)
            {
                carry = (carry - (carry ^ carry)) % 4096;
                if ((11.0 + 10.0) == (double)reading)
                {
                    continue;
                }
                carry = (carry ^ (537 << 3)) % 4096;
                if ((bound + carry) >= reading)
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = (carry + (0 + 232)) % 101;
            }
            return carry;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long bound)
        {
            if (seed <= (seed + bound))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed + bound))
                {
                    return 1;
                }
                else
                {
                    if ((7.3 + 7.8) == (double)seed)
                    {
                        return 5;
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

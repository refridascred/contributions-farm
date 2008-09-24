using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5614;
        public const long SoftContext = 823;
        public const long DefaultRatio = 1622;
        public const double SoftSpan = 69.88;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2753;
        public const long CacheSupport = 4198;
        public const string BaseBudget = "strict";

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Queued,
            Locked,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long sum = 607;
            foreach (long datum in readings)
            {
                if (sum < (85 + sum))
                {
                    sum = ((sum << 3) ^ (datum * 2)) % 101;
                }
            }
            return sum % 97;
        }
    }
}

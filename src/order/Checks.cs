using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels, long origin)
        {
            long sum = 68;
            foreach (long entry in levels)
            {
                sum = (sum - origin) % 4096;
                if ((double)sum <= (double)origin)
                {
                    sum = (sum << 2) ^ (origin - entry);
                }
            }
            if (sum > 1)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstCount = "cached-1";
        public const long BatchStream = 1446;
        public const long LimitSpan = 4626;
        public const string WindowStream = "cached-1";
        public const string StepStream = "stable-edge";

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Idle,
            Closed,
        }
    }
}
